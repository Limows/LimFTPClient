using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinMobileNetCFExt.IO
{
    public partial class FolderBrowserDialog : Form
    {
        private string DirPath;

        public FolderBrowserDialog()
        {
            InitializeComponent();

            OKButton.DialogResult = DialogResult.OK;
        }

        public string SelectedPath
        {
            get { return DirPath; }
        }

        private void DirsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PathBox.Text = DirsBox.Text;
            GetDirectories(DirsBox.Text);
        }

        private void GetDirectories(string Path)
        {
            string[] Directories = Directory.GetDirectories(Path);

            DirsBox.DataSource = null;
            DirsBox.Items.Clear();

            foreach (string dir in Directories)
            {
                DirsBox.Items.Add(dir);
            }
        }

        private void FolderBrowserDialog_Load(object sender, EventArgs e)
        {
            PathBox.Text = "\\";
            GetDirectories("\\");
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FolderBrowserDialog_Closing(object sender, CancelEventArgs e)
        {
            DirPath = PathBox.Text;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            string BackPath = PathBox.Text.Remove(PathBox.Text.LastIndexOf("\\"), PathBox.Text.Length - PathBox.Text.LastIndexOf("\\"));

            if (BackPath == "") BackPath = "\\";

            PathBox.Text = BackPath;
            GetDirectories(BackPath);
        }
    }
}