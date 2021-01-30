namespace LimFTPClient
{
    partial class ParamsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu MainMenu;

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
            this.MainMenu = new System.Windows.Forms.MainMenu();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DownloadPathLabel = new System.Windows.Forms.Label();
            this.OpenDirButton1 = new System.Windows.Forms.Button();
            this.DownloadPathBox = new System.Windows.Forms.TextBox();
            this.InstallPathLabel = new System.Windows.Forms.Label();
            this.AutoInstallBox = new System.Windows.Forms.CheckBox();
            this.RmPackageBox = new System.Windows.Forms.CheckBox();
            this.OverwriteDirsBox = new System.Windows.Forms.CheckBox();
            this.DeviceInstallButton = new System.Windows.Forms.RadioButton();
            this.CardInstallButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(81, 236);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(77, 20);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DownloadPathLabel
            // 
            this.DownloadPathLabel.Location = new System.Drawing.Point(5, 155);
            this.DownloadPathLabel.Name = "DownloadPathLabel";
            this.DownloadPathLabel.Size = new System.Drawing.Size(100, 20);
            this.DownloadPathLabel.Text = "Путь загрузки";
            // 
            // OpenDirButton1
            // 
            this.OpenDirButton1.Location = new System.Drawing.Point(178, 177);
            this.OpenDirButton1.Name = "OpenDirButton1";
            this.OpenDirButton1.Size = new System.Drawing.Size(57, 21);
            this.OpenDirButton1.TabIndex = 6;
            this.OpenDirButton1.Text = "Обзор";
            this.OpenDirButton1.Click += new System.EventHandler(this.OpenDirButton1_Click);
            // 
            // DownloadPathBox
            // 
            this.DownloadPathBox.Location = new System.Drawing.Point(5, 177);
            this.DownloadPathBox.Name = "DownloadPathBox";
            this.DownloadPathBox.Size = new System.Drawing.Size(167, 21);
            this.DownloadPathBox.TabIndex = 5;
            // 
            // InstallPathLabel
            // 
            this.InstallPathLabel.Location = new System.Drawing.Point(5, 98);
            this.InstallPathLabel.Name = "InstallPathLabel";
            this.InstallPathLabel.Size = new System.Drawing.Size(100, 20);
            this.InstallPathLabel.Text = "Место установки";
            // 
            // AutoInstallBox
            // 
            this.AutoInstallBox.Location = new System.Drawing.Point(5, 63);
            this.AutoInstallBox.Name = "AutoInstallBox";
            this.AutoInstallBox.Size = new System.Drawing.Size(230, 20);
            this.AutoInstallBox.TabIndex = 13;
            this.AutoInstallBox.Text = "Автоматическая установка";
            // 
            // RmPackageBox
            // 
            this.RmPackageBox.Location = new System.Drawing.Point(5, 37);
            this.RmPackageBox.Name = "RmPackageBox";
            this.RmPackageBox.Size = new System.Drawing.Size(230, 20);
            this.RmPackageBox.TabIndex = 14;
            this.RmPackageBox.Text = "Удалить после установки";
            // 
            // OverwriteDirsBox
            // 
            this.OverwriteDirsBox.Location = new System.Drawing.Point(5, 11);
            this.OverwriteDirsBox.Name = "OverwriteDirsBox";
            this.OverwriteDirsBox.Size = new System.Drawing.Size(230, 20);
            this.OverwriteDirsBox.TabIndex = 15;
            this.OverwriteDirsBox.Text = "Перезаписывать файлы";
            // 
            // DeviceInstallButton
            // 
            this.DeviceInstallButton.Location = new System.Drawing.Point(5, 121);
            this.DeviceInstallButton.Name = "DeviceInstallButton";
            this.DeviceInstallButton.Size = new System.Drawing.Size(100, 20);
            this.DeviceInstallButton.TabIndex = 16;
            this.DeviceInstallButton.Text = "Устройство";
            // 
            // CardInstallButton
            // 
            this.CardInstallButton.Location = new System.Drawing.Point(111, 121);
            this.CardInstallButton.Name = "CardInstallButton";
            this.CardInstallButton.Size = new System.Drawing.Size(100, 20);
            this.CardInstallButton.TabIndex = 17;
            this.CardInstallButton.Text = "SD Card";
            // 
            // ParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.ControlBox = false;
            this.Controls.Add(this.CardInstallButton);
            this.Controls.Add(this.DeviceInstallButton);
            this.Controls.Add(this.OverwriteDirsBox);
            this.Controls.Add(this.RmPackageBox);
            this.Controls.Add(this.AutoInstallBox);
            this.Controls.Add(this.InstallPathLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DownloadPathLabel);
            this.Controls.Add(this.OpenDirButton1);
            this.Controls.Add(this.DownloadPathBox);
            this.Menu = this.MainMenu;
            this.Name = "ParamsForm";
            this.Text = "Параметры";
            this.Load += new System.EventHandler(this.ParamsBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label DownloadPathLabel;
        private System.Windows.Forms.Button OpenDirButton1;
        private System.Windows.Forms.TextBox DownloadPathBox;
        private System.Windows.Forms.Label InstallPathLabel;
        private System.Windows.Forms.CheckBox AutoInstallBox;
        private System.Windows.Forms.CheckBox RmPackageBox;
        private System.Windows.Forms.CheckBox OverwriteDirsBox;
        private System.Windows.Forms.RadioButton DeviceInstallButton;
        private System.Windows.Forms.RadioButton CardInstallButton;
    }
}