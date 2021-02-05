namespace LimFTPClient
{
    partial class ParamsForm
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
            this.BufferTabPage = new System.Windows.Forms.TabPage();
            this.UsedTempSizeBox = new System.Windows.Forms.Label();
            this.UsedTempSizeLabel = new System.Windows.Forms.Label();
            this.MBLabel = new System.Windows.Forms.Label();
            this.TempSizeBox = new System.Windows.Forms.TextBox();
            this.TempSizeLabel = new System.Windows.Forms.Label();
            this.CleanBufferButton = new System.Windows.Forms.Button();
            this.InstallTabPage = new System.Windows.Forms.TabPage();
            this.OverwriteDirsBox = new System.Windows.Forms.CheckBox();
            this.RmPackageBox = new System.Windows.Forms.CheckBox();
            this.AutoInstallBox = new System.Windows.Forms.CheckBox();
            this.InstallPathLabel = new System.Windows.Forms.Label();
            this.DownloadTabPage = new System.Windows.Forms.TabPage();
            this.HttpServerButton = new System.Windows.Forms.RadioButton();
            this.FtpServerButton = new System.Windows.Forms.RadioButton();
            this.ServerTypeLabel = new System.Windows.Forms.Label();
            this.DownloadPathBox = new System.Windows.Forms.TextBox();
            this.DownloadPathLabel = new System.Windows.Forms.Label();
            this.OpenDirButton = new System.Windows.Forms.Button();
            this.ParamsTabControl = new System.Windows.Forms.TabControl();
            this.BufferTabPage.SuspendLayout();
            this.InstallTabPage.SuspendLayout();
            this.DownloadTabPage.SuspendLayout();
            this.ParamsTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // BufferTabPage
            // 
            this.BufferTabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BufferTabPage.Controls.Add(this.UsedTempSizeBox);
            this.BufferTabPage.Controls.Add(this.UsedTempSizeLabel);
            this.BufferTabPage.Controls.Add(this.MBLabel);
            this.BufferTabPage.Controls.Add(this.TempSizeBox);
            this.BufferTabPage.Controls.Add(this.TempSizeLabel);
            this.BufferTabPage.Controls.Add(this.CleanBufferButton);
            this.BufferTabPage.Location = new System.Drawing.Point(23, 4);
            this.BufferTabPage.Name = "BufferTabPage";
            this.BufferTabPage.Size = new System.Drawing.Size(241, 286);
            this.BufferTabPage.TabIndex = 2;
            this.BufferTabPage.Text = "Хранилище";
            // 
            // UsedTempSizeBox
            // 
            this.UsedTempSizeBox.Location = new System.Drawing.Point(96, 39);
            this.UsedTempSizeBox.Name = "UsedTempSizeBox";
            this.UsedTempSizeBox.Size = new System.Drawing.Size(104, 20);
            this.UsedTempSizeBox.TabIndex = 0;
            this.UsedTempSizeBox.Text = "0 МБ";
            // 
            // UsedTempSizeLabel
            // 
            this.UsedTempSizeLabel.Location = new System.Drawing.Point(8, 39);
            this.UsedTempSizeLabel.Name = "UsedTempSizeLabel";
            this.UsedTempSizeLabel.Size = new System.Drawing.Size(116, 21);
            this.UsedTempSizeLabel.TabIndex = 1;
            this.UsedTempSizeLabel.Text = "Занято сейчас:";
            // 
            // MBLabel
            // 
            this.MBLabel.Location = new System.Drawing.Point(165, 14);
            this.MBLabel.Name = "MBLabel";
            this.MBLabel.Size = new System.Drawing.Size(25, 20);
            this.MBLabel.TabIndex = 2;
            this.MBLabel.Text = "МБ";
            // 
            // TempSizeBox
            // 
            this.TempSizeBox.Location = new System.Drawing.Point(114, 11);
            this.TempSizeBox.Name = "TempSizeBox";
            this.TempSizeBox.Size = new System.Drawing.Size(45, 20);
            this.TempSizeBox.TabIndex = 10;
            // 
            // TempSizeLabel
            // 
            this.TempSizeLabel.Location = new System.Drawing.Point(8, 14);
            this.TempSizeLabel.Name = "TempSizeLabel";
            this.TempSizeLabel.Size = new System.Drawing.Size(116, 21);
            this.TempSizeLabel.TabIndex = 11;
            this.TempSizeLabel.Text = "Размер хранилища:";
            // 
            // CleanBufferButton
            // 
            this.CleanBufferButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CleanBufferButton.Location = new System.Drawing.Point(8, 63);
            this.CleanBufferButton.Name = "CleanBufferButton";
            this.CleanBufferButton.Size = new System.Drawing.Size(79, 21);
            this.CleanBufferButton.TabIndex = 8;
            this.CleanBufferButton.Text = "Очистить";
            this.CleanBufferButton.UseVisualStyleBackColor = false;
            this.CleanBufferButton.Click += new System.EventHandler(this.CleanBufferButton_Click);
            // 
            // InstallTabPage
            // 
            this.InstallTabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InstallTabPage.Controls.Add(this.OverwriteDirsBox);
            this.InstallTabPage.Controls.Add(this.RmPackageBox);
            this.InstallTabPage.Controls.Add(this.AutoInstallBox);
            this.InstallTabPage.Controls.Add(this.InstallPathLabel);
            this.InstallTabPage.Location = new System.Drawing.Point(23, 4);
            this.InstallTabPage.Name = "InstallTabPage";
            this.InstallTabPage.Size = new System.Drawing.Size(241, 286);
            this.InstallTabPage.TabIndex = 1;
            this.InstallTabPage.Text = "Установка";
            // 
            // OverwriteDirsBox
            // 
            this.OverwriteDirsBox.Location = new System.Drawing.Point(8, 14);
            this.OverwriteDirsBox.Name = "OverwriteDirsBox";
            this.OverwriteDirsBox.Size = new System.Drawing.Size(222, 20);
            this.OverwriteDirsBox.TabIndex = 6;
            this.OverwriteDirsBox.Text = "Перезапись файлов";
            // 
            // RmPackageBox
            // 
            this.RmPackageBox.Location = new System.Drawing.Point(8, 40);
            this.RmPackageBox.Name = "RmPackageBox";
            this.RmPackageBox.Size = new System.Drawing.Size(222, 20);
            this.RmPackageBox.TabIndex = 7;
            this.RmPackageBox.Text = "Удаление пакета";
            this.RmPackageBox.CheckedChanged += new System.EventHandler(this.RmPackageBox_CheckedChanged);
            // 
            // AutoInstallBox
            // 
            this.AutoInstallBox.Location = new System.Drawing.Point(8, 66);
            this.AutoInstallBox.Name = "AutoInstallBox";
            this.AutoInstallBox.Size = new System.Drawing.Size(222, 20);
            this.AutoInstallBox.TabIndex = 8;
            this.AutoInstallBox.Text = "Установка после загрузки";
            // 
            // InstallPathLabel
            // 
            this.InstallPathLabel.Location = new System.Drawing.Point(5, 94);
            this.InstallPathLabel.Name = "InstallPathLabel";
            this.InstallPathLabel.Size = new System.Drawing.Size(225, 20);
            this.InstallPathLabel.TabIndex = 9;
            this.InstallPathLabel.Text = "Диск для установки";
            // 
            // DownloadTabPage
            // 
            this.DownloadTabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DownloadTabPage.Controls.Add(this.HttpServerButton);
            this.DownloadTabPage.Controls.Add(this.FtpServerButton);
            this.DownloadTabPage.Controls.Add(this.ServerTypeLabel);
            this.DownloadTabPage.Controls.Add(this.DownloadPathBox);
            this.DownloadTabPage.Controls.Add(this.DownloadPathLabel);
            this.DownloadTabPage.Controls.Add(this.OpenDirButton);
            this.DownloadTabPage.Location = new System.Drawing.Point(23, 4);
            this.DownloadTabPage.Name = "DownloadTabPage";
            this.DownloadTabPage.Size = new System.Drawing.Size(241, 286);
            this.DownloadTabPage.TabIndex = 0;
            this.DownloadTabPage.Text = "Загрузка";
            // 
            // HttpServerButton
            // 
            this.HttpServerButton.Enabled = false;
            this.HttpServerButton.Location = new System.Drawing.Point(10, 63);
            this.HttpServerButton.Name = "HttpServerButton";
            this.HttpServerButton.Size = new System.Drawing.Size(100, 20);
            this.HttpServerButton.TabIndex = 10;
            this.HttpServerButton.Text = "HTTP сервер";
            this.HttpServerButton.CheckedChanged += new System.EventHandler(this.HttpServerButton_CheckedChanged);
            // 
            // FtpServerButton
            // 
            this.FtpServerButton.Checked = true;
            this.FtpServerButton.Location = new System.Drawing.Point(10, 37);
            this.FtpServerButton.Name = "FtpServerButton";
            this.FtpServerButton.Size = new System.Drawing.Size(100, 20);
            this.FtpServerButton.TabIndex = 9;
            this.FtpServerButton.TabStop = true;
            this.FtpServerButton.Text = "FTP сервер";
            // 
            // ServerTypeLabel
            // 
            this.ServerTypeLabel.Location = new System.Drawing.Point(8, 14);
            this.ServerTypeLabel.Name = "ServerTypeLabel";
            this.ServerTypeLabel.Size = new System.Drawing.Size(226, 20);
            this.ServerTypeLabel.TabIndex = 11;
            this.ServerTypeLabel.Text = "Тип сервера";
            // 
            // DownloadPathBox
            // 
            this.DownloadPathBox.Location = new System.Drawing.Point(10, 115);
            this.DownloadPathBox.Name = "DownloadPathBox";
            this.DownloadPathBox.Size = new System.Drawing.Size(163, 20);
            this.DownloadPathBox.TabIndex = 6;
            this.DownloadPathBox.TextChanged += new System.EventHandler(this.DownloadPathBox_TextChanged);
            this.DownloadPathBox.GotFocus += new System.EventHandler(this.DownloadPathBox_GotFocus);
            this.DownloadPathBox.LostFocus += new System.EventHandler(this.DownloadPathBox_LostFocus);
            // 
            // DownloadPathLabel
            // 
            this.DownloadPathLabel.Location = new System.Drawing.Point(8, 92);
            this.DownloadPathLabel.Name = "DownloadPathLabel";
            this.DownloadPathLabel.Size = new System.Drawing.Size(100, 20);
            this.DownloadPathLabel.TabIndex = 12;
            this.DownloadPathLabel.Text = "Путь загрузки";
            // 
            // OpenDirButton
            // 
            this.OpenDirButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OpenDirButton.Location = new System.Drawing.Point(176, 115);
            this.OpenDirButton.Name = "OpenDirButton";
            this.OpenDirButton.Size = new System.Drawing.Size(57, 20);
            this.OpenDirButton.TabIndex = 7;
            this.OpenDirButton.Text = "Обзор";
            this.OpenDirButton.UseVisualStyleBackColor = false;
            this.OpenDirButton.Click += new System.EventHandler(this.OpenDirButton1_Click);
            // 
            // ParamsTabControl
            // 
            this.ParamsTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.ParamsTabControl.Controls.Add(this.DownloadTabPage);
            this.ParamsTabControl.Controls.Add(this.InstallTabPage);
            this.ParamsTabControl.Controls.Add(this.BufferTabPage);
            this.ParamsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParamsTabControl.Location = new System.Drawing.Point(0, 0);
            this.ParamsTabControl.Multiline = true;
            this.ParamsTabControl.Name = "ParamsTabControl";
            this.ParamsTabControl.SelectedIndex = 0;
            this.ParamsTabControl.Size = new System.Drawing.Size(268, 294);
            this.ParamsTabControl.TabIndex = 11;
            // 
            // ParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(268, 294);
            this.Controls.Add(this.ParamsTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParamsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ParamsForm_Closing);
            this.Load += new System.EventHandler(this.ParamsBox_Load);
            this.BufferTabPage.ResumeLayout(false);
            this.BufferTabPage.PerformLayout();
            this.InstallTabPage.ResumeLayout(false);
            this.DownloadTabPage.ResumeLayout(false);
            this.DownloadTabPage.PerformLayout();
            this.ParamsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage BufferTabPage;
        private System.Windows.Forms.TabPage InstallTabPage;
        private System.Windows.Forms.CheckBox OverwriteDirsBox;
        private System.Windows.Forms.CheckBox RmPackageBox;
        private System.Windows.Forms.CheckBox AutoInstallBox;
        private System.Windows.Forms.Label InstallPathLabel;
        private System.Windows.Forms.TabPage DownloadTabPage;
        private System.Windows.Forms.TextBox DownloadPathBox;
        private System.Windows.Forms.Label DownloadPathLabel;
        private System.Windows.Forms.Button OpenDirButton;
        private System.Windows.Forms.TabControl ParamsTabControl;
        private System.Windows.Forms.Label ServerTypeLabel;
        private System.Windows.Forms.RadioButton HttpServerButton;
        private System.Windows.Forms.RadioButton FtpServerButton;
        private System.Windows.Forms.TextBox TempSizeBox;
        private System.Windows.Forms.Label TempSizeLabel;
        private System.Windows.Forms.Label MBLabel;
        private System.Windows.Forms.Button CleanBufferButton;
        private System.Windows.Forms.Label UsedTempSizeBox;
        private System.Windows.Forms.Label UsedTempSizeLabel;
    }
}