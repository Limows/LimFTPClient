using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LimFTPClient
{
    public partial class ParamsBox : Form
    {
        public ParamsBox()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (DownloadPathBox.Text != "")
            {	
				if  (Directory.Exists(DownloadPathBox.Text))
				{
					Parameters.DownloadPath = DownloadPathBox.Text;
					Close();
				}
				else
				{
					DialogResult Result = MessageBox.Show("Такая папка не сушествует.\nСоздать?", "Предупреждение",MessageBoxButtons.YesNo);
					
					if (Result == DialogResult.Yes)
					{
						Directory.CreateDirectory(DownloadPathBox.Text)
					}
				}
            }
            else
            {
                MessageBox.Show("Путь не может быть пустым", "Предупреждение");
            }
        }

        private void ParamsBox_Load(object sender, EventArgs e)
        {
            DownloadPathBox.Text = Parameters.DownloadPath;
        }

        private void OpenDirButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog OpenDir = new FolderBrowserDialog();
            if (OpenDir.ShowDialog() == DialogResult.OK)
            {
                DownloadPathBox.Text = OpenDir.SelectedPath;
            }
        }
    }
}
