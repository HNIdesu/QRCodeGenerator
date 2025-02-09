﻿namespace QRCodeGenerator
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
            addToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            tabControl1 = new TabControl();
            tabPage_shorttext = new TabPage();
            textBox_shorttext = new TextBox();
            tabPage_longtext = new TabPage();
            textBox_longtext = new TextBox();
            tabPage_multimedia = new TabPage();
            chromiumWebBrowser_multimedia = new CefSharp.WinForms.ChromiumWebBrowser();
            pictureBox_qrcode = new PictureBox();
            openFileDialog = new OpenFileDialog();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage_shorttext.SuspendLayout();
            tabPage_longtext.SuspendLayout();
            tabPage_multimedia.SuspendLayout();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingToolStripMenuItem, addToolStripMenuItem });
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
            settingToolStripMenuItem.Click += settingToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(44, 21);
            addToolStripMenuItem.Text = "添加";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox_qrcode);
            splitContainer1.Size = new Size(927, 403);
            splitContainer1.SplitterDistance = 511;
            splitContainer1.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.AllowDrop = true;
            tabControl1.Controls.Add(tabPage_shorttext);
            tabControl1.Controls.Add(tabPage_longtext);
            tabControl1.Controls.Add(tabPage_multimedia);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(511, 403);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage_shorttext
            // 
            tabPage_shorttext.Controls.Add(textBox_shorttext);
            tabPage_shorttext.Location = new Point(4, 26);
            tabPage_shorttext.Name = "tabPage_shorttext";
            tabPage_shorttext.Padding = new Padding(3);
            tabPage_shorttext.Size = new Size(503, 373);
            tabPage_shorttext.TabIndex = 0;
            tabPage_shorttext.Text = "短文本";
            tabPage_shorttext.UseVisualStyleBackColor = true;
            // 
            // textBox_shorttext
            // 
            textBox_shorttext.AllowDrop = true;
            textBox_shorttext.Dock = DockStyle.Fill;
            textBox_shorttext.ImeMode = ImeMode.On;
            textBox_shorttext.Location = new Point(3, 3);
            textBox_shorttext.MaxLength = 256;
            textBox_shorttext.Multiline = true;
            textBox_shorttext.Name = "textBox_shorttext";
            textBox_shorttext.Size = new Size(497, 367);
            textBox_shorttext.TabIndex = 0;
            textBox_shorttext.TextChanged += textBox_shorttext_TextChanged;
            textBox_shorttext.DragDrop += textBox_text_DragDrop;
            textBox_shorttext.DragEnter += control_DragEnter;
            // 
            // tabPage_longtext
            // 
            tabPage_longtext.Controls.Add(textBox_longtext);
            tabPage_longtext.Location = new Point(4, 26);
            tabPage_longtext.Name = "tabPage_longtext";
            tabPage_longtext.Padding = new Padding(3);
            tabPage_longtext.Size = new Size(503, 373);
            tabPage_longtext.TabIndex = 1;
            tabPage_longtext.Text = "长文本";
            tabPage_longtext.UseVisualStyleBackColor = true;
            // 
            // textBox_longtext
            // 
            textBox_longtext.AllowDrop = true;
            textBox_longtext.Dock = DockStyle.Fill;
            textBox_longtext.ImeMode = ImeMode.On;
            textBox_longtext.Location = new Point(3, 3);
            textBox_longtext.MaxLength = 655360;
            textBox_longtext.Multiline = true;
            textBox_longtext.Name = "textBox_longtext";
            textBox_longtext.Size = new Size(497, 367);
            textBox_longtext.TabIndex = 0;
            textBox_longtext.TextChanged += textBox_longtext_TextChanged;
            textBox_longtext.DragDrop += textBox_text_DragDrop;
            textBox_longtext.DragEnter += control_DragEnter;
            // 
            // tabPage_multimedia
            // 
            tabPage_multimedia.Controls.Add(chromiumWebBrowser_multimedia);
            tabPage_multimedia.Location = new Point(4, 26);
            tabPage_multimedia.Name = "tabPage_multimedia";
            tabPage_multimedia.Padding = new Padding(3);
            tabPage_multimedia.Size = new Size(503, 373);
            tabPage_multimedia.TabIndex = 4;
            tabPage_multimedia.Text = "多媒体";
            tabPage_multimedia.UseVisualStyleBackColor = true;
            // 
            // chromiumWebBrowser_multimedia
            // 
            chromiumWebBrowser_multimedia.ActivateBrowserOnCreation = false;
            chromiumWebBrowser_multimedia.Dock = DockStyle.Fill;
            chromiumWebBrowser_multimedia.Location = new Point(3, 3);
            chromiumWebBrowser_multimedia.Name = "chromiumWebBrowser_multimedia";
            chromiumWebBrowser_multimedia.Size = new Size(497, 367);
            chromiumWebBrowser_multimedia.TabIndex = 0;
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
            tabControl1.ResumeLayout(false);
            tabPage_shorttext.ResumeLayout(false);
            tabPage_shorttext.PerformLayout();
            tabPage_longtext.ResumeLayout(false);
            tabPage_longtext.PerformLayout();
            tabPage_multimedia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_qrcode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox_qrcode;
        private ToolStripStatusLabel toolStripStatusLabel_status;
        private ToolStripMenuItem settingToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private TabControl tabControl1;
        private TabPage tabPage_shorttext;
        private TextBox textBox_shorttext;
        private TabPage tabPage_longtext;
        private TextBox textBox_longtext;
        private TabPage tabPage_image;
        private TabPage tabPage_multimedia;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser_multimedia;
        private ToolStripMenuItem addToolStripMenuItem;
    }
}