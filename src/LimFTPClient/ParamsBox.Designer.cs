namespace LimFTPClient
{
    partial class ParamsBox
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
            this.DownloadPathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenDirButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DownloadPathBox
            // 
            this.DownloadPathBox.Location = new System.Drawing.Point(98, 186);
            this.DownloadPathBox.Name = "DownloadPathBox";
            this.DownloadPathBox.Size = new System.Drawing.Size(168, 20);
            this.DownloadPathBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь загрузки";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(137, 365);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenDirButton
            // 
            this.OpenDirButton.Location = new System.Drawing.Point(273, 185);
            this.OpenDirButton.Name = "OpenDirButton";
            this.OpenDirButton.Size = new System.Drawing.Size(75, 23);
            this.OpenDirButton.TabIndex = 3;
            this.OpenDirButton.Text = "Обзор";
            this.OpenDirButton.UseVisualStyleBackColor = true;
            this.OpenDirButton.Click += new System.EventHandler(this.OpenDirButton_Click);
            // 
            // ParamsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(366, 400);
            this.ControlBox = false;
            this.Controls.Add(this.OpenDirButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DownloadPathBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParamsBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ParamsBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DownloadPathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenDirButton;
    }
}