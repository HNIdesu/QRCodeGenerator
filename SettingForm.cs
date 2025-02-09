﻿namespace QRCodeGenerator
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            textBox_hostname.Text = AppConfig.Host;
            textBox_port.Text = AppConfig.Port.ToString();
            checkBox_enableNetTraverse.Checked = AppConfig.EnableNetTraverse;
            textBox_url.Text = AppConfig.NetTraverseUrl;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool CheckInput()
        {
            if (!(textBox_port.Text.Trim() != "" && int.TryParse(textBox_port.Text.Trim(), out int port) && (port > 0 && port < 65536)))
            {
                MessageBox.Show("无效端口");
                textBox_port.Focus();
                return false;
            }
            if (textBox_url.Text.Trim() != "")
            {
                try
                {
                    Uri uri = new Uri(textBox_url.Text.Trim());
                }
                catch (Exception)
                {
                    MessageBox.Show("无效的内网穿透url");
                    textBox_port.Focus();
                    return false;
                }

            }

            return true;

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            int port = int.Parse(textBox_port.Text.Trim());
            if (AppConfig.Port != port)
                AppConfig.Port = port;
            string host = textBox_hostname.Text.Trim();
            if (host != AppConfig.Host)
                AppConfig.Host = host;
            if (AppConfig.EnableNetTraverse != checkBox_enableNetTraverse.Checked)
                AppConfig.EnableNetTraverse = checkBox_enableNetTraverse.Checked;
            string url = textBox_url.Text.Trim();
            if (!url.Contains('?') && !url.EndsWith('/')) url += "/";
            if (host != AppConfig.NetTraverseUrl)
                AppConfig.NetTraverseUrl = url;

            Close();
        }

    }
}
