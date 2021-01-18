using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace LimFTPClient
{
    public partial class AppForm : Form
    {
        private string AppName;

        public AppForm(string CurrentAppName)
        {
            InitializeComponent();

            AppName = CurrentAppName;
        }



        private async void DownloadButton_Click(object sender, EventArgs e)
        {
            string FileName = AppName + ".zip";
            Parameters.CurrentURI = new Uri(Parameters.AppURI.ToString() + "/" + FileName);
            //MessageBox.Show(Parameters.CurrentURI.ToString());

            if (Parameters.DownloadPath != null)
            {
                Label.Text = "Загрузка в папку " + Parameters.DownloadPath;
                try
                {
                    await Task.Run(() => FTP.DownloadFile(Parameters.CurrentURI, Parameters.DownloadPath + "\\" + FileName));
                    Label.Text = "Успешно загружено";

                    DialogResult Result = MessageBox.Show("Распаковать пакет?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Result == DialogResult.Yes)
                    {
                        ZipFile.ExtractToDirectory(Parameters.DownloadPath + "\\" + FileName, Parameters.DownloadPath + "\\" + AppName);
                        //IO.ExtractToDirectory(Parameters.DownloadPath + "\\" + FileName, Parameters.DownloadPath + "\\" + AppName);
                    }
                }
                catch (WebException Exception)
                {
                    if ((int)((FtpWebResponse)Exception.Response).StatusCode == 550)
                    {
                        File.Delete(Parameters.DownloadPath + "\\" + FileName);
                    }
                    else
                    {
                        MessageBox.Show("Невозможно сохранить в " + Parameters.DownloadPath + "\nВозможно программа должна быть\nзапущена от имени администратора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Label.Text = "Загрузка не удалась";
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Невозможно сохранить в " + Parameters.DownloadPath + "\nВозможно программа должна быть\nзапущена от имени администратора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Label.Text = "Загрузка не удалась";
                }


            }
            else
            {
                MessageBox.Show("Отсутствует путь для сохранения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Parameters.CurrentURI = Parameters.AppURI;
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            this.Text = AppName;
            string InfoFileName = AppName + ".info";
            NameLabel.Text = AppName;
            Label.Text = "";

            Parameters.CurrentURI = new Uri(Parameters.AppURI.ToString() + "/" + InfoFileName);

            try
            {
                AboutAppBox.Text = FTP.LoadInfo(Parameters.CurrentURI);            
            }
            catch
            {
                AboutAppBox.Text = "Для этого приложения ещё нет описания";
            }
            Parameters.CurrentURI = Parameters.AppURI;


        }

        private void AppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parameters.CurrentURI = Parameters.SystemURI;
            //MessageBox.Show(Parameters.CurrentURI.ToString());
        }
    }
}
