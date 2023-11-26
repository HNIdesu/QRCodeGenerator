namespace QRCodeGenerator
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label1;
            Label label2;
            Label label3;
            splitContainer1 = new SplitContainer();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            textBox_url = new TextBox();
            checkBox_enableNetTraverse = new CheckBox();
            textBox_port = new TextBox();
            textBox_hostname = new TextBox();
            button_ok = new Button();
            button_cancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 42);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 1;
            label1.Text = "域名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 86);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 2;
            label2.Text = "端口";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 61);
            label3.Name = "label3";
            label3.Size = new Size(25, 17);
            label3.TabIndex = 5;
            label3.Text = "Url";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button_ok);
            splitContainer1.Panel2.Controls.Add(button_cancel);
            splitContainer1.Size = new Size(572, 450);
            splitContainer1.SplitterDistance = 386;
            splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(572, 386);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(textBox_port);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox_hostname);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(564, 356);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "服务器";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_url);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkBox_enableNetTraverse);
            groupBox1.Location = new Point(49, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 107);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // textBox_url
            // 
            textBox_url.Location = new Point(65, 58);
            textBox_url.MaxLength = 64;
            textBox_url.Name = "textBox_url";
            textBox_url.Size = new Size(188, 23);
            textBox_url.TabIndex = 6;
            // 
            // checkBox_enableNetTraverse
            // 
            checkBox_enableNetTraverse.AutoSize = true;
            checkBox_enableNetTraverse.Location = new Point(7, 22);
            checkBox_enableNetTraverse.Name = "checkBox_enableNetTraverse";
            checkBox_enableNetTraverse.Size = new Size(75, 21);
            checkBox_enableNetTraverse.TabIndex = 4;
            checkBox_enableNetTraverse.Text = "内网穿透";
            checkBox_enableNetTraverse.UseVisualStyleBackColor = true;
            // 
            // textBox_port
            // 
            textBox_port.Location = new Point(114, 83);
            textBox_port.MaxLength = 6;
            textBox_port.Name = "textBox_port";
            textBox_port.Size = new Size(188, 23);
            textBox_port.TabIndex = 3;
            // 
            // textBox_hostname
            // 
            textBox_hostname.Location = new Point(114, 39);
            textBox_hostname.MaxLength = 64;
            textBox_hostname.Name = "textBox_hostname";
            textBox_hostname.Size = new Size(188, 23);
            textBox_hostname.TabIndex = 0;
            // 
            // button_ok
            // 
            button_ok.Location = new Point(474, 16);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(75, 23);
            button_ok.TabIndex = 1;
            button_ok.Text = "确定";
            button_ok.UseVisualStyleBackColor = true;
            button_ok.Click += button_ok_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(370, 16);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(75, 23);
            button_cancel.TabIndex = 0;
            button_cancel.Text = "取消";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 450);
            Controls.Add(splitContainer1);
            Name = "SettingForm";
            Text = "设置";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button_ok;
        private Button button_cancel;
        private TextBox textBox_hostname;
        private TextBox textBox_port;
        private Label label2;
        private GroupBox groupBox1;
        private CheckBox checkBox_enableNetTraverse;
        private TextBox textBox_url;
    }
}