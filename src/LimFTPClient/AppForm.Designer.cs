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
            this.DownloadButton = new System.Windows.Forms.Button();
            this.AboutAppBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(18, 280);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(75, 23);
            this.DownloadButton.TabIndex = 0;
            this.DownloadButton.Text = "Скачать";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // AboutAppBox
            // 
            this.AboutAppBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AboutAppBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutAppBox.Location = new System.Drawing.Point(307, 12);
            this.AboutAppBox.Name = "AboutAppBox";
            this.AboutAppBox.ReadOnly = true;
            this.AboutAppBox.Size = new System.Drawing.Size(167, 258);
            this.AboutAppBox.TabIndex = 1;
            this.AboutAppBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(486, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AboutAppBox);
            this.Controls.Add(this.DownloadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AppForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppForm_FormClosing);
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.RichTextBox AboutAppBox;
        private System.Windows.Forms.Label label1;
    }
}