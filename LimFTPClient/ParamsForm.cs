using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LimFTPClient
{
    public partial class ParamsForm : Form
    {
        public ParamsForm()
        {
            InitializeComponent();
        }

        private string CheckDirectory(string Path)
        {
            if (Directory.Exists(Path))
            {
                return Path;
            }
            else
            {
                DialogResult Result = MessageBox.Show("Такая директория не существует.\nСоздать?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (Result == DialogResult.Yes)
                {
                    try
                    {
                        Directory.CreateDirectory(Path);
                        return Path;
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось создать директорию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        return "";
                    }
                }
                else return "";
            }
        }

        private void OpenDirButton1_Click(object sender, EventArgs e)
        {
            DownloadPathBox.Text = OpenDirDialog();
        }

        private string OpenDirDialog()
        {
            FolderBrowserDialog OpenDir = new FolderBrowserDialog();

            if (OpenDir.ShowDialog() == DialogResult.OK)
            {
                return OpenDir.SelectedPath;
            }
            else return "";
        }

        private void ParamsBox_Load(object sender, EventArgs e)
        {
            DownloadPathBox.Text = ParamsHelper.DownloadPath;
            OverwriteDirsBox.Checked = ParamsHelper.IsOverwrite;
            AutoInstallBox.Checked = ParamsHelper.IsAutoInstall;
            RmPackageBox.Checked = ParamsHelper.IsRmPackage;

            List<string> DrivesNames = IOHelper.GetDrivesList();
            int Top = 115;
            int Left = 8;

            foreach (string drive in DrivesNames)
            {
                RadioButton DriveButton = new RadioButton();

                DriveButton.Left = Left;
                DriveButton.Top = Top;
                DriveButton.Text = drive;
                DriveButton.Name = "DriveButton" + drive.Replace(":\\", "");
                DriveButton.CheckedChanged += DriveButton_CheckedChanged;

                if (drive == ParamsHelper.InstallPath.Split('\\')[0] + "\\")
                {
                    DriveButton.Checked = true;
                }

                InstallTabPage.Controls.Add(DriveButton);

                Top += 20;
            }
        }

        private void DriveButton_CheckedChanged(object sender, EventArgs e)
        {
            string DriveName;

            try
            {
                if (((RadioButton)sender).Checked)
                {
                    DriveName = ((RadioButton)sender).Text;

                    ParamsHelper.InstallPath = DriveName + @"Program Files";
                }
            }
            catch
            {
                ParamsHelper.InstallPath = null;
            }


        }

        private void DownloadPathBox_GotFocus(object sender, EventArgs e)
        {
            //InputPanel.Enabled = true;
        }

        private void DownloadPathBox_LostFocus(object sender, EventArgs e)
        {
            //InputPanel.Enabled = false;
        }

        private void CleanBufferButton_Click(object sender, EventArgs e)
        {
            try
            {
                IOHelper.CleanBuffer();
            }
            catch
            {

            }
        }

        private void ParamsForm_Closing(object sender, CancelEventArgs e)
        {
            ParamsHelper.DownloadPath = CheckDirectory(DownloadPathBox.Text);
            ParamsHelper.IsAutoInstall = AutoInstallBox.Checked;
            ParamsHelper.IsRmPackage = RmPackageBox.Checked;
            ParamsHelper.IsOverwrite = OverwriteDirsBox.Checked;

            if (String.IsNullOrEmpty(ParamsHelper.InstallPath))
            {
                MessageBox.Show("Выберите диск для установки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
                return;
            }
            else
            {
                if (!Directory.Exists(ParamsHelper.InstallPath))
                {
                    Directory.CreateDirectory(ParamsHelper.InstallPath);
                }
            }


            if (String.IsNullOrEmpty(ParamsHelper.DownloadPath))
            {
                MessageBox.Show("Путь не может быть пустым", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
                return;
            }

            e.Cancel = false;
        }

        private void HttpServerButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DownloadPathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RmPackageBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}