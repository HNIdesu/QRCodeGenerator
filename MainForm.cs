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
            pictureBox_preview.AllowDrop = true;
            mContentProvider = new ContentProvider(AppConfig.Host, AppConfig.Port);
            mContentProvider.Start();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox_qrcode.Image = (tabControl1.SelectedTab?.Tag as Bitmap)?? Resources.preview;
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


        private void pictureBox_preview_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                openFileDialog_pickimage.FileName = "";
                if (openFileDialog_pickimage.ShowDialog() == DialogResult.OK)
                {
                    string filepath = openFileDialog_pickimage.FileName;
                    if (File.Exists(filepath))
                    {
                        Image img = Image.FromFile(openFileDialog_pickimage.FileName);
                        pictureBox_preview.Image = img;
                        string ext = Path.GetExtension(filepath).Remove(0, 1);
                        if (ext == "jpg")
                            ext = "jpeg";
                        string token = mContentProvider.SetData($"image/{ext}", () => File.ReadAllBytes(filepath));
                        pictureBox_qrcode.Image = QRCodeHelper.GetQRCode(GenerateValidUrl(token), 36, Color.Black, Color.White, QRCoder.QRCodeGenerator.ECCLevel.L, forceUtf8: true);
                        tabPage_image.Tag = pictureBox_qrcode.Image;
                    }
                    else
                    {
                        MessageBox.Show("选择的文件不存在,请检查路径后重试");
                        pictureBox_preview.Image = Resources.preview;
                    }


                }
            }
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

        private static readonly HashSet<string> mImageExtension = [".png", ".jpeg", ".jpg", ".webp", ".bmp"];

        private void pictureBox_preview_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            string? filepath = (e.Data?.GetData("FileNameW") as string[])?[0];
            if (filepath != null && mImageExtension.Contains(Path.GetExtension(filepath).ToLower()))
            {
                try
                {
                    Image image = Image.FromFile(filepath);
                    pictureBox.Image = image;
                    string ext = Path.GetExtension(filepath).Remove(0, 1);
                    if (ext == "jpg")
                        ext = "jpeg";
                    string token = mContentProvider.SetData($"image/{ext}", () => File.ReadAllBytes(filepath));
                    pictureBox_qrcode.Image = QRCodeHelper.GetQRCode(GenerateValidUrl(token), 36, Color.Black, Color.White, QRCoder.QRCodeGenerator.ECCLevel.L, forceUtf8: true);
                    tabPage_image.Tag = pictureBox_qrcode.Image;
                }
                catch (Exception)
                {
                    MessageBox.Show("无法识别图像格式");
                }

            }
            else
            {
                MessageBox.Show("文件格式不支持");
            }


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
    }
}