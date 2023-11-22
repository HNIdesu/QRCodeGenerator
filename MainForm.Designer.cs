namespace QRCodeGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel_status = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            settingToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox_shorttext = new TextBox();
            tabPage2 = new TabPage();
            textBox_longtext = new TextBox();
            tabPage3 = new TabPage();
            pictureBox_preview = new PictureBox();
            button_pickimage = new Button();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            button_generate = new Button();
            pictureBox_qrcode = new PictureBox();
            openFileDialog_pickimage = new OpenFileDialog();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_preview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_qrcode).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel_status });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(927, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_status
            // 
            toolStripStatusLabel_status.Name = "toolStripStatusLabel_status";
            toolStripStatusLabel_status.Size = new Size(0, 17);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(927, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(44, 21);
            settingToolStripMenuItem.Text = "设置";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox_qrcode);
            splitContainer1.Size = new Size(927, 403);
            splitContainer1.SplitterDistance = 511;
            splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(button_generate);
            splitContainer2.Size = new Size(511, 403);
            splitContainer2.SplitterDistance = 351;
            splitContainer2.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(511, 351);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox_shorttext);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(503, 321);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "文本";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_shorttext
            // 
            textBox_shorttext.Dock = DockStyle.Fill;
            textBox_shorttext.Location = new Point(3, 3);
            textBox_shorttext.MaxLength = 256;
            textBox_shorttext.Multiline = true;
            textBox_shorttext.Name = "textBox_shorttext";
            textBox_shorttext.Size = new Size(497, 315);
            textBox_shorttext.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox_longtext);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(503, 321);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "长文本";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_longtext
            // 
            textBox_longtext.Dock = DockStyle.Fill;
            textBox_longtext.Location = new Point(3, 3);
            textBox_longtext.Multiline = true;
            textBox_longtext.Name = "textBox_longtext";
            textBox_longtext.Size = new Size(497, 315);
            textBox_longtext.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.Control;
            tabPage3.Controls.Add(pictureBox_preview);
            tabPage3.Controls.Add(button_pickimage);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(503, 321);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "图片";
            // 
            // pictureBox_preview
            // 
            pictureBox_preview.BackColor = SystemColors.ButtonHighlight;
            pictureBox_preview.Dock = DockStyle.Bottom;
            pictureBox_preview.Image = Properties.Resources.preview;
            pictureBox_preview.Location = new Point(3, 61);
            pictureBox_preview.Name = "pictureBox_preview";
            pictureBox_preview.Size = new Size(497, 257);
            pictureBox_preview.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_preview.TabIndex = 1;
            pictureBox_preview.TabStop = false;
            // 
            // button_pickimage
            // 
            button_pickimage.Location = new Point(21, 21);
            button_pickimage.Name = "button_pickimage";
            button_pickimage.Size = new Size(75, 23);
            button_pickimage.TabIndex = 0;
            button_pickimage.Text = "浏览";
            button_pickimage.UseVisualStyleBackColor = true;
            button_pickimage.Click += button_pickimage_Click;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 26);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(503, 321);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "音乐";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 26);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(503, 321);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "视频";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button_generate
            // 
            button_generate.Location = new Point(12, 12);
            button_generate.Name = "button_generate";
            button_generate.Size = new Size(75, 23);
            button_generate.TabIndex = 0;
            button_generate.Text = "生成";
            button_generate.UseVisualStyleBackColor = true;
            button_generate.Click += button_generate_Click;
            // 
            // pictureBox_qrcode
            // 
            pictureBox_qrcode.Dock = DockStyle.Fill;
            pictureBox_qrcode.Image = Properties.Resources.preview;
            pictureBox_qrcode.InitialImage = null;
            pictureBox_qrcode.Location = new Point(0, 0);
            pictureBox_qrcode.Name = "pictureBox_qrcode";
            pictureBox_qrcode.Size = new Size(412, 403);
            pictureBox_qrcode.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_qrcode.TabIndex = 0;
            pictureBox_qrcode.TabStop = false;
            // 
            // openFileDialog_pickimage
            // 
            openFileDialog_pickimage.Filter = "图片|*.png;*.jpg;*.webp;*.jpeg";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 450);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "QRCode Generator";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_preview).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_qrcode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox_qrcode;
        private SplitContainer splitContainer2;
        private Button button_generate;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox_shorttext;
        private ToolStripStatusLabel toolStripStatusLabel_status;
        private ToolStripMenuItem settingToolStripMenuItem;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TextBox textBox_longtext;
        private Button button_pickimage;
        private PictureBox pictureBox_preview;
        private OpenFileDialog openFileDialog_pickimage;
    }
}