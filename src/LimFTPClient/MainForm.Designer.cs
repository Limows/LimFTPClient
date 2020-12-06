namespace LimFTPClient
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SystemsBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ParamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ConnectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SearchBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemsBox
            // 
            this.SystemsBox.BackColor = System.Drawing.SystemColors.Window;
            this.SystemsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SystemsBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SystemsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SystemsBox.FormattingEnabled = true;
            this.SystemsBox.ItemHeight = 16;
            this.SystemsBox.Location = new System.Drawing.Point(0, 55);
            this.SystemsBox.Name = "SystemsBox";
            this.SystemsBox.Size = new System.Drawing.Size(460, 384);
            this.SystemsBox.TabIndex = 0;
            this.SystemsBox.Click += new System.EventHandler(this.SystemsBox_Click);
            this.SystemsBox.SelectedIndexChanged += new System.EventHandler(this.SystemsBox_SelectedIndexChanged);
            this.SystemsBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SystemsBox_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(276, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите нужную систему";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.Window;
            this.BackButton.BackgroundImage = global::LimFTPClient.Properties.Resources.BackButton;
            this.BackButton.Location = new System.Drawing.Point(-1, 24);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(30, 30);
            this.BackButton.TabIndex = 2;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ParamsToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ParamsToolStripMenuItem
            // 
            this.ParamsToolStripMenuItem.Name = "ParamsToolStripMenuItem";
            this.ParamsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.ParamsToolStripMenuItem.Text = "Параметры";
            this.ParamsToolStripMenuItem.Click += new System.EventHandler(this.ParamsToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectionStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(459, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "StatusStrip";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(45, 17);
            this.ConnectionStatusLabel.Text = "Default";
            this.ConnectionStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBox.Location = new System.Drawing.Point(33, 27);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.SearchBox.Size = new System.Drawing.Size(237, 25);
            this.SearchBox.TabIndex = 6;
            this.SearchBox.Text = "Поиск";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(459, 463);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SystemsBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "LimFTP Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SystemsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ParamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ConnectionStatusLabel;
        private System.Windows.Forms.RichTextBox SearchBox;
    }
}

