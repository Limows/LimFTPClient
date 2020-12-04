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
                Parameters.DownloadPath = DownloadPathBox.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Отсуствует путь", "Ошибка");
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
