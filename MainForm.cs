using QRCodeGenerator.Properties;
using QRCoder;
using System.Text;

namespace QRCodeGenerator
{
    public partial class MainForm : Form
    {
        private ContentProvider ContentProvider = new ContentProvider("192.168.1.2", 2321);
        private static readonly string ExternalUrl = "https://dummy.net";

        private static string GenerateValidUrl(string token) => ExternalUrl + $"?token={token}";

        public MainForm()
        {
            InitializeComponent();
            pictureBox_preview.AllowDrop = true;
            ContentProvider.Start();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image? qrcode = tabControl1.SelectedTab.Tag as Bitmap;
            if (qrcode == null)
                qrcode = Resources.preview;
            pictureBox_qrcode.Image = qrcode;
        }

        private void textBox_shorttext_TextChanged(object sender, EventArgs e)
        {
            pictureBox_qrcode.Image = QRCodeHelper.GetQRCode(textBox_shorttext.Text, 36, Color.Black, Color.White, QRCoder.QRCodeGenerator.ECCLevel.L, forceUtf8: true);
            tabPage_shorttext.Tag = pictureBox_qrcode.Image;
        }

        private void textBox_longtext_TextChanged(object sender, EventArgs e)
        {
            string html = Resources.EncryptHtml.Replace("!!encrypted_data!!", EncryptUtil.EncryptText(textBox_longtext.Text));
            string token = ContentProvider.SetData("text/html", () => Encoding.ASCII.GetBytes(html));
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
                        string token = ContentProvider.SetData($"image/{ext}", () => File.ReadAllBytes(filepath));
                        pictureBox_qrcode.Image = QRCodeHelper.GetQRCode(GenerateValidUrl(token), 36, Color.Black, Color.White, QRCoder.QRCodeGenerator.ECCLevel.L, forceUtf8: true);
                        tabPage_image.Tag = pictureBox_qrcode.Image;
                    }
                    else
                    {
                        MessageBox.Show("ѡ����ļ�������,����·��������");
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

        private void pictureBox_preview_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            string? filepath = (e.Data?.GetData("FileNameW") as string[])?[0];
            if (filepath != null && (new string[] { ".png", "jpeg", ".jpg", ".webp", "bmp" }).Any(ext => filepath.EndsWith(ext)))
            {
                try
                {
                    Image image = Image.FromFile(filepath);
                    pictureBox.Image = image;
                    string ext = Path.GetExtension(filepath).Remove(0, 1);
                    if (ext == "jpg")
                        ext = "jpeg";
                    string token = ContentProvider.SetData($"image/{ext}", () => File.ReadAllBytes(filepath));
                    pictureBox_qrcode.Image = QRCodeHelper.GetQRCode(GenerateValidUrl(token), 36, Color.Black, Color.White, QRCoder.QRCodeGenerator.ECCLevel.L, forceUtf8: true);
                    tabPage_image.Tag = pictureBox_qrcode.Image;
                }
                catch (Exception)
                {
                    MessageBox.Show("�޷�ʶ��ͼ���ʽ");
                }

            }
            else
            {
                MessageBox.Show("�ļ���ʽ��֧��");
            }


        }

    }
}