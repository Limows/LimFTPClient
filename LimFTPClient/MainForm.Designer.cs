namespace LimFTPClient
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.ActionsMenuItem = new System.Windows.Forms.MenuItem();
            this.ParamsMenuItem = new System.Windows.Forms.MenuItem();
            this.UpdateMenuItem = new System.Windows.Forms.MenuItem();
            this.ExitMenuItem = new System.Windows.Forms.MenuItem();
            this.RefMenu = new System.Windows.Forms.MenuItem();
            this.HelpMenuItem = new System.Windows.Forms.MenuItem();
            this.AboutMenuItem = new System.Windows.Forms.MenuItem();
            this.UpdateSysMenuItem = new System.Windows.Forms.MenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.NewPage = new System.Windows.Forms.TabPage();
            this.CategoriesTree = new System.Windows.Forms.TreeView();
            this.AppsBox = new System.Windows.Forms.ListBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InstalledPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.InstalledLabel = new System.Windows.Forms.Label();
            this.PropButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MemLabel = new System.Windows.Forms.Label();
            this.FreeMemLabel = new System.Windows.Forms.Label();
            this.InstalledBox = new System.Windows.Forms.ListBox();
            this.ListingThreadTimer = new System.Windows.Forms.Timer(this.components);
            this.TabControl.SuspendLayout();
            this.NewPage.SuspendLayout();
            this.InstalledPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ActionsMenuItem,
            this.RefMenu});
            // 
            // ActionsMenuItem
            // 
            this.ActionsMenuItem.Index = 0;
            this.ActionsMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ParamsMenuItem,
            this.UpdateMenuItem,
            this.ExitMenuItem});
            this.ActionsMenuItem.Text = "Действия";
            // 
            // ParamsMenuItem
            // 
            this.ParamsMenuItem.Index = 0;
            this.ParamsMenuItem.Text = "Параметры";
            this.ParamsMenuItem.Click += new System.EventHandler(this.ParamsMenuItem_Click);
            // 
            // UpdateMenuItem
            // 
            this.UpdateMenuItem.Index = 1;
            this.UpdateMenuItem.Text = "Обновить";
            this.UpdateMenuItem.Click += new System.EventHandler(this.BackMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Index = 2;
            this.ExitMenuItem.Text = "Выход";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // RefMenu
            // 
            this.RefMenu.Index = 1;
            this.RefMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.HelpMenuItem,
            this.AboutMenuItem,
            this.UpdateSysMenuItem});
            this.RefMenu.Text = "Справка";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Index = 0;
            this.HelpMenuItem.Text = "Помощь";
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Index = 1;
            this.AboutMenuItem.Text = "О программе";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // UpdateSysMenuItem
            // 
            this.UpdateSysMenuItem.Index = 2;
            this.UpdateSysMenuItem.Text = "Обновления";
            this.UpdateSysMenuItem.Click += new System.EventHandler(this.UpdateSysMenuItem_Click);
            // 
            // TabControl
            // 
            this.TabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabControl.Controls.Add(this.NewPage);
            this.TabControl.Controls.Add(this.InstalledPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(624, 390);
            this.TabControl.TabIndex = 7;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // NewPage
            // 
            this.NewPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewPage.Controls.Add(this.CategoriesTree);
            this.NewPage.Controls.Add(this.AppsBox);
            this.NewPage.Controls.Add(this.SearchBox);
            this.NewPage.Controls.Add(this.label1);
            this.NewPage.Location = new System.Drawing.Point(23, 4);
            this.NewPage.Name = "NewPage";
            this.NewPage.Size = new System.Drawing.Size(597, 382);
            this.NewPage.TabIndex = 0;
            this.NewPage.Text = "Приложения";
            // 
            // CategoriesTree
            // 
            this.CategoriesTree.Location = new System.Drawing.Point(10, 8);
            this.CategoriesTree.Name = "CategoriesTree";
            this.CategoriesTree.Size = new System.Drawing.Size(180, 366);
            this.CategoriesTree.TabIndex = 7;
            // 
            // AppsBox
            // 
            this.AppsBox.Location = new System.Drawing.Point(199, 58);
            this.AppsBox.Name = "AppsBox";
            this.AppsBox.Size = new System.Drawing.Size(387, 316);
            this.AppsBox.TabIndex = 5;
            this.AppsBox.SelectedIndexChanged += new System.EventHandler(this.SystemsBox_SelectedIndexChanged);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(199, 31);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(388, 20);
            this.SearchBox.TabIndex = 3;
            this.SearchBox.Text = "Поиск";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(199, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите нужное приложение";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InstalledPage
            // 
            this.InstalledPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InstalledPage.Controls.Add(this.label2);
            this.InstalledPage.Controls.Add(this.richTextBox1);
            this.InstalledPage.Controls.Add(this.InstalledLabel);
            this.InstalledPage.Controls.Add(this.PropButton);
            this.InstalledPage.Controls.Add(this.DeleteButton);
            this.InstalledPage.Controls.Add(this.MemLabel);
            this.InstalledPage.Controls.Add(this.FreeMemLabel);
            this.InstalledPage.Controls.Add(this.InstalledBox);
            this.InstalledPage.Location = new System.Drawing.Point(23, 4);
            this.InstalledPage.Name = "InstalledPage";
            this.InstalledPage.Size = new System.Drawing.Size(597, 382);
            this.InstalledPage.TabIndex = 1;
            this.InstalledPage.Text = "Установленные";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(384, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Свойства";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(384, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(203, 299);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // InstalledLabel
            // 
            this.InstalledLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstalledLabel.Location = new System.Drawing.Point(10, 6);
            this.InstalledLabel.Name = "InstalledLabel";
            this.InstalledLabel.Size = new System.Drawing.Size(382, 22);
            this.InstalledLabel.TabIndex = 0;
            this.InstalledLabel.Text = "Установленные приложения";
            this.InstalledLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PropButton
            // 
            this.PropButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PropButton.Location = new System.Drawing.Point(381, 353);
            this.PropButton.Name = "PropButton";
            this.PropButton.Size = new System.Drawing.Size(72, 20);
            this.PropButton.TabIndex = 4;
            this.PropButton.Text = "Свойства";
            this.PropButton.UseVisualStyleBackColor = false;
            this.PropButton.Click += new System.EventHandler(this.PropButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteButton.Location = new System.Drawing.Point(459, 353);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(72, 20);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MemLabel
            // 
            this.MemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemLabel.Location = new System.Drawing.Point(493, 333);
            this.MemLabel.Name = "MemLabel";
            this.MemLabel.Size = new System.Drawing.Size(93, 20);
            this.MemLabel.TabIndex = 5;
            this.MemLabel.Text = "FreeMem";
            // 
            // FreeMemLabel
            // 
            this.FreeMemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreeMemLabel.Location = new System.Drawing.Point(384, 333);
            this.FreeMemLabel.Name = "FreeMemLabel";
            this.FreeMemLabel.Size = new System.Drawing.Size(112, 20);
            this.FreeMemLabel.TabIndex = 6;
            this.FreeMemLabel.Text = "Доступно памяти:";
            // 
            // InstalledBox
            // 
            this.InstalledBox.Location = new System.Drawing.Point(10, 31);
            this.InstalledBox.Name = "InstalledBox";
            this.InstalledBox.Size = new System.Drawing.Size(365, 342);
            this.InstalledBox.TabIndex = 0;
            // 
            // ListingThreadTimer
            // 
            this.ListingThreadTimer.Tick += new System.EventHandler(this.ListingThreadTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(624, 390);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Menu = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "LimFTP Client";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.TabControl.ResumeLayout(false);
            this.NewPage.ResumeLayout(false);
            this.NewPage.PerformLayout();
            this.InstalledPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem ActionsMenuItem;
        private System.Windows.Forms.MenuItem RefMenu;
        private System.Windows.Forms.MenuItem ParamsMenuItem;
        private System.Windows.Forms.MenuItem UpdateMenuItem;
        private System.Windows.Forms.MenuItem HelpMenuItem;
        private System.Windows.Forms.MenuItem AboutMenuItem;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage NewPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage InstalledPage;
        private System.Windows.Forms.ListBox AppsBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label FreeMemLabel;
        private System.Windows.Forms.ListBox InstalledBox;
        private System.Windows.Forms.Label MemLabel;
        private System.Windows.Forms.Button PropButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label InstalledLabel;
        private System.Windows.Forms.MenuItem ExitMenuItem;
        private System.Windows.Forms.Timer ListingThreadTimer;
        private System.Windows.Forms.MenuItem UpdateSysMenuItem;
        private System.Windows.Forms.TreeView CategoriesTree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

