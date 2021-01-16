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
            this.DownloadButton = new System.Windows.Forms.Button();
            this.AboutAppBox = new System.Windows.Forms.RichTextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.AppLogo = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.ShotLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DownloadButton
            // 
            this.DownloadButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DownloadButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadButton.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DownloadButton.Location = new System.Drawing.Point(12, 82);
            this.DownloadButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(88, 27);
            this.DownloadButton.TabIndex = 0;
            this.DownloadButton.Text = "Скачать";
            this.DownloadButton.UseVisualStyleBackColor = false;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // AboutAppBox
            // 
            this.AboutAppBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AboutAppBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutAppBox.Location = new System.Drawing.Point(12, 115);
            this.AboutAppBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AboutAppBox.Name = "AboutAppBox";
            this.AboutAppBox.ReadOnly = true;
            this.AboutAppBox.Size = new System.Drawing.Size(266, 236);
            this.AboutAppBox.TabIndex = 1;
            this.AboutAppBox.Text = "";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(190, -55);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 15);
            this.StatusLabel.TabIndex = 3;
            // 
            // AppLogo
            // 
            this.AppLogo.Image = ((System.Drawing.Image)(resources.GetObject("AppLogo.Image")));
            this.AppLogo.InitialImage = null;
            this.AppLogo.Location = new System.Drawing.Point(12, 14);
            this.AppLogo.Name = "AppLogo";
            this.AppLogo.Size = new System.Drawing.Size(50, 50);
            this.AppLogo.TabIndex = 4;
            this.AppLogo.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(68, 14);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(59, 15);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Название";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(68, 31);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(46, 15);
            this.VersionLabel.TabIndex = 6;
            this.VersionLabel.Text = "Версия";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(68, 49);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(47, 15);
            this.SizeLabel.TabIndex = 7;
            this.SizeLabel.Text = "Размер";
            // 
            // ShotLabel
            // 
            this.ShotLabel.AutoSize = true;
            this.ShotLabel.Location = new System.Drawing.Point(294, 14);
            this.ShotLabel.Name = "ShotLabel";
            this.ShotLabel.Size = new System.Drawing.Size(65, 15);
            this.ShotLabel.TabIndex = 8;
            this.ShotLabel.Text = "Скриншот";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(294, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 319);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(117, 88);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(43, 15);
            this.Label.TabIndex = 10;
            this.Label.Text = "Статус";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(567, 363);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ShotLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AppLogo);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.AboutAppBox);
            this.Controls.Add(this.DownloadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AppForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppForm_FormClosing);
            this.Load += new System.EventHandler(this.AppForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.RichTextBox AboutAppBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.PictureBox AppLogo;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label ShotLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label;
    }
}