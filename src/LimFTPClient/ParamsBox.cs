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
            Parameters.DownloadPath = DownloadPathBox.Text;
            Close();
        }

        private void ParamsBox_Load(object sender, EventArgs e)
        {
            DownloadPathBox.Text = Parameters.DownloadPath;
        }
    }
}
