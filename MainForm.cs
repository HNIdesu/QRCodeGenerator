using PCLWebUtility;
using QRCodeGenerator.Properties;
using QRCoder;
using System.Text;

namespace QRCodeGenerator
{
    public partial class MainForm : Form
    {
        private ContentProvider ContentProvider = new ContentProvider();
        private static readonly string ExternalUrl = "https://dummy.net";

        public MainForm()
        {
            InitializeComponent();
            ContentProvider.Start();
        }

        
        private void button_generate_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0://短文本
                    {
                        pictureBox_qrcode.Image = QRCodeHelper.GetQRCode(textBox_shorttext.Text, 36, Color.Black, Color.White, QRCoder.QRCodeGenerator.ECCLevel.L, forceUtf8: true);
                    }
                    break;
                case 1://长文本
                    {
                        string raw_data = textBox_longtext.Text;
                        string encryped_data = WebUtility.UrlEncode(raw_data).Replace("%","&");
                        string html = Resources.EncryptHtml.Replace("!!encrypted_data!!", encryped_data);
                        ContentProvider.SetData("text/html", () => Encoding.ASCII.GetBytes(html));
                        pictureBox_qrcode.Image = QRCodeHelper.GetQRCode(ExternalUrl, 36, Color.Black, Color.White, QRCoder.QRCodeGenerator.ECCLevel.L, forceUtf8: true);
                    }
                    break;
                case 2://图片
                    {
                        string filename = openFileDialog_pickimage.FileName;
                        if (File.Exists(filename))
                        {
                            string ext = Path.GetExtension(filename).Remove(0, 1);
                            if (ext == "jpg")
                                ext = "jpeg";
                            ContentProvider.SetData($"image/{ext}", () => File.ReadAllBytes(openFileDialog_pickimage.FileName));
                            pictureBox_qrcode.Image = QRCodeHelper.GetQRCode(ExternalUrl, 36, Color.Black, Color.White, QRCoder.QRCodeGenerator.ECCLevel.L, forceUtf8: true);
                        }
                        else
                            MessageBox.Show("选择的图片不存在,请检查路径后重试");
                    }
                    break;
                default:
                    break;
            }
        }

        private void button_pickimage_Click(object sender, EventArgs e)
        {
            openFileDialog_pickimage.FileName = "";
            if (openFileDialog_pickimage.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog_pickimage.FileName;
                if (File.Exists(filepath))
                    pictureBox_preview.Image = Image.FromFile(openFileDialog_pickimage.FileName);
                else
                {
                    MessageBox.Show("选择的文件不存在,请检查路径后重试");
                    pictureBox_preview.Image = Resources.preview;
                }


            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox_qrcode.Image = Resources.preview;
        }
    }
}