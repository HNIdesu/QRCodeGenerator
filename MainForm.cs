using QRCodeGenerator.Properties;
using QRCoder;
using System.Text;

namespace QRCodeGenerator
{
    public partial class MainForm : Form
    {

        private ContentProvider mContentProvider;

        private static string GenerateValidUrl(string token)
        {
            if (AppConfig.EnableNetTraverse)
                return AppConfig.NetTraverseUrl + $"?token={token}";
            else
                return $"http://{AppConfig.Host}:{AppConfig.Port}/" + $"?token={token}";
        }

        public MainForm()
        {
            InitializeComponent();
            mContentProvider = new ContentProvider(AppConfig.Host, AppConfig.Port);
            mContentProvider.Start();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox_qrcode.Image = (tabControl1.SelectedTab?.Tag as Bitmap) ?? Resources.preview;
        }

        private void textBox_shorttext_TextChanged(object sender, EventArgs e)
        {
            pictureBox_qrcode.Image = QRCodeHelper.GetQRCode(textBox_shorttext.Text, 36, Color.Black, Color.White, QRCoder.QRCodeGenerator.ECCLevel.L, forceUtf8: true);
            tabPage_shorttext.Tag = pictureBox_qrcode.Image;
        }

        private void textBox_longtext_TextChanged(object sender, EventArgs e)
        {
            string html = Resources.EncryptHtml.Replace("!!encrypted_data!!", EncryptUtil.EncryptText(textBox_longtext.Text));
            string token = mContentProvider.SetData("text/html", () => Encoding.ASCII.GetBytes(html));
            pictureBox_qrcode.Image = QRCodeHelper.GetQRCode(GenerateValidUrl(token), 36, Color.Black, Color.White, QRCoder.QRCodeGenerator.ECCLevel.L, forceUtf8: true);
            tabPage_longtext.Tag = pictureBox_qrcode.Image;
        }

        private void textBox_text_DragDrop(object sender, DragEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            string? filepath = (e.Data?.GetData("FileNameW") as string[])?[0];
            if (filepath != null)
            {
                using (StreamReader reader = new StreamReader(File.OpenRead(filepath)))
                {
                    char[] buffer = new char[textBox.MaxLength];
                    reader.Read(buffer);
                    textBox.Text = new string(buffer);
                }
            }

        }

        private void control_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingForm().ShowDialog();
            if (mContentProvider.Address != AppConfig.Host || mContentProvider.Port != AppConfig.Port)
            {
                mContentProvider.DisconnectAll();
                mContentProvider.Dispose();
                mContentProvider = new ContentProvider(AppConfig.Host, AppConfig.Port);
                mContentProvider.Start();
            }

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFile();
        }

        private void AddShortTextFile()
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;
                if (File.Exists(filepath))
                    textBox_shorttext.Text = File.ReadAllText(filepath);
                else
                {
                    MessageBox.Show("选择的文件不存在,请检查路径后重试");
                    textBox_shorttext.Text = "";
                }
            }
        }

        private void AddLongTextFile()
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;
                if (File.Exists(filepath))
                    textBox_longtext.Text = File.ReadAllText(filepath);
                else
                {
                    MessageBox.Show("选择的文件不存在,请检查路径后重试");
                    textBox_longtext.Text = "";
                }
            }
        }

        private void AddMultiMediaFile()
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = string.Format("图片|{0}|音频|{1}|视频|{2}",
                string.Join(';', MimeUtility.KnownImageExtensions.Select(it => $"*.{it}")),
                string.Join(';', MimeUtility.KnownAudioExtensions.Select(it => $"*.{it}")),
                string.Join(';', MimeUtility.KnownVideoExtensions.Select(it => $"*.{it}"))
            );
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;
                if (File.Exists(filepath))
                {
                    
                    string token = mContentProvider.SetData(MimeUtility.GetMimeMapping(filepath), () => File.ReadAllBytes(filepath));
                    var url = GenerateValidUrl(token);
                    pictureBox_qrcode.Image = QRCodeHelper.GetQRCode(url, 36, Color.Black, Color.White, QRCoder.QRCodeGenerator.ECCLevel.L, forceUtf8: true);
                    chromiumWebBrowser_multimedia.LoadUrl(url);
                    tabPage_multimedia.Tag = pictureBox_qrcode.Image;
                }
                else
                {
                    MessageBox.Show("选择的文件不存在,请检查路径后重试");
                }
            }
        }

        private void AddFile()
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    AddShortTextFile();
                    break;
                case 1:
                    AddLongTextFile();
                    break;
                case 2:
                    AddMultiMediaFile();
                    break;
            }
        }
    }
}