namespace LimFTPClient
{
    partial class AboutAppBox
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
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.textBoxInstallPath = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.labelInstallDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelProductName
            // 
            this.labelProductName.Location = new System.Drawing.Point(7, 10);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(226, 20);
            this.labelProductName.Text = "Имя программы";
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(7, 30);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(226, 20);
            this.labelVersion.Text = "Версия";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Location = new System.Drawing.Point(7, 50);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(226, 20);
            this.labelCompanyName.Text = "Имя компании";
            this.labelCompanyName.ParentChanged += new System.EventHandler(this.labelCompanyName_ParentChanged);
            // 
            // textBoxInstallPath
            // 
            this.textBoxInstallPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.textBoxInstallPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInstallPath.Location = new System.Drawing.Point(9, 90);
            this.textBoxInstallPath.Multiline = true;
            this.textBoxInstallPath.Name = "textBoxInstallPath";
            this.textBoxInstallPath.ReadOnly = true;
            this.textBoxInstallPath.Size = new System.Drawing.Size(224, 142);
            this.textBoxInstallPath.TabIndex = 7;
            this.textBoxInstallPath.Text = "Путь установки ";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(161, 240);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(72, 20);
            this.OKButton.TabIndex = 12;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // labelInstallDate
            // 
            this.labelInstallDate.Location = new System.Drawing.Point(7, 70);
            this.labelInstallDate.Name = "labelInstallDate";
            this.labelInstallDate.Size = new System.Drawing.Size(226, 20);
            this.labelInstallDate.Text = "Дата установки";
            // 
            // AboutAppBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.labelInstallDate);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.textBoxInstallPath);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelProductName);
            this.Name = "AboutAppBox";
            this.Text = "О программе";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxInstallPath;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label labelInstallDate;
    }
}