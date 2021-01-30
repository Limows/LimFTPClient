namespace WinMobileNetCFExt.IO
{
    partial class FolderBrowserDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.DirsBox = new System.Windows.Forms.ListBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DirsBox
            // 
            this.DirsBox.Location = new System.Drawing.Point(0, 20);
            this.DirsBox.Name = "DirsBox";
            this.DirsBox.Size = new System.Drawing.Size(240, 212);
            this.DirsBox.TabIndex = 0;
            this.DirsBox.SelectedIndexChanged += new System.EventHandler(this.DirsBox_SelectedIndexChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(83, 241);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(72, 20);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(20, 0);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(220, 21);
            this.PathBox.TabIndex = 2;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(21, 21);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "<";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FolderBrowserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DirsBox);
            this.Menu = this.mainMenu1;
            this.Name = "FolderBrowserDialog";
            this.Text = "Обзор";
            this.Load += new System.EventHandler(this.FolderBrowserDialog_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FolderBrowserDialog_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DirsBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Button BackButton;
    }
}