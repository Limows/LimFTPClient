using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using WinMobileNetCFExt.IO;

namespace LimFTPClient
{
    public partial class ParamsForm : Form
    {
        public ParamsForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ParamsHelper.DownloadPath = CheckDirectory(DownloadPathBox.Text);
            ParamsHelper.IsAutoInstall = AutoInstallBox.Checked;
            ParamsHelper.IsRmPackage = RmPackageBox.Checked;
            ParamsHelper.IsOverwrite = OverwriteDirsBox.Checked;

            if (DeviceInstallButton.Checked)
            {
                ParamsHelper.InstallPath = "\\Program Files";
            }
            else
            {
                ParamsHelper.InstallPath = "\\" + IO.GetRemovableStorageDirectory() + "\\Program Files";
            }

            if (!Directory.Exists(ParamsHelper.InstallPath))
            {
                Directory.CreateDirectory(ParamsHelper.InstallPath);
            }

            if (String.IsNullOrEmpty(ParamsHelper.DownloadPath))
            {
                MessageBox.Show("Путь не может быть пустым", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else Close();
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

            if (ParamsHelper.InstallPath == "\\Program Files")
            {
                DeviceInstallButton.Checked = true;
            }
            else
            {
                CardInstallButton.Checked = true;
            }

            RmPackageBox.Checked = false;
            RmPackageBox.Enabled = false;

        }
    }
}