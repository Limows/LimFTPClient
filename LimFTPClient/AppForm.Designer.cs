namespace LimFTPClient
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.AboutAppBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.DownloadingTimer = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // LogoBox
            // 
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.Location = new System.Drawing.Point(12, 14);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(50, 50);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(68, 14);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(166, 20);
            this.NameLabel.Text = "Название";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Location = new System.Drawing.Point(68, 32);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(166, 20);
            this.CategoryLabel.Text = "Раздел";
            // 
            // SizeLabel
            // 
            this.SizeLabel.Location = new System.Drawing.Point(68, 50);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(166, 20);
            this.SizeLabel.Text = "Размер";
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(12, 74);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(72, 20);
            this.DownloadButton.TabIndex = 6;
            this.DownloadButton.Text = "Скачать";
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // AboutAppBox
            // 
            this.AboutAppBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.AboutAppBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutAppBox.Location = new System.Drawing.Point(12, 101);
            this.AboutAppBox.Multiline = true;
            this.AboutAppBox.Name = "AboutAppBox";
            this.AboutAppBox.Size = new System.Drawing.Size(222, 190);
            this.AboutAppBox.TabIndex = 7;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Location = new System.Drawing.Point(92, 77);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(142, 20);
            this.StatusLabel.Text = "Статус";
            // 
            // DownloadingTimer
            // 
            this.DownloadingTimer.Tick += new System.EventHandler(this.DownloadingTimer_Tick);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.AboutAppBox);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LogoBox);
            this.Name = "AppForm";
            this.Text = "AppForm";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.AppForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.TextBox AboutAppBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Timer DownloadingTimer;
    }
}