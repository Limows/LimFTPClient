using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace LimFTPClient
{
    public partial class AppForm : Form
    {
        string AppName;

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
                label1.Text = "Загрузка " + AppName + " в папку " + Parameters.DownloadPath;
                await Task.Run(() => FTP.DownloadFile(Parameters.CurrentURI, Parameters.DownloadPath + "\\" + FileName));
                label1.Text = "Успешно загружено";
            }
            else
            {
                MessageBox.Show("Отсутствует путь для сохранения файла", "Ошибка");
            }

            Parameters.CurrentURI = Parameters.AppURI;
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            this.Text = AppName;
            string InfoFileName = AppName + ".info";
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
