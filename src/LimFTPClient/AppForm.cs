using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

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



        private void DownloadButton_Click(object sender, EventArgs e)
        {
            string FileName = AppName + ".zip";
            Parameters.CurrentURI = new Uri(Parameters.AppURI.ToString() + "/" + FileName);
            //MessageBox.Show(Parameters.CurrentURI.ToString());
            if (Parameters.DownloadPath != null)
                DownloadFile(Parameters.CurrentURI, Parameters.DownloadPath + FileName);
            else MessageBox.Show("Отсутствует путь для сохранения файла", "Ошибка");
            Parameters.CurrentURI = Parameters.AppURI;
        }

        private Stream CreateDownloadRequest(Uri URI)
        {
            FtpWebRequest FTPRequest = (FtpWebRequest)WebRequest.Create(URI);
            FTPRequest.UseBinary = true;
            FTPRequest.KeepAlive = false;
            FTPRequest.Credentials = new NetworkCredential("anon", "");
            FTPRequest.Method = WebRequestMethods.Ftp.DownloadFile;

            FtpWebResponse Response = (FtpWebResponse)FTPRequest.GetResponse();
            return Response.GetResponseStream();
        }

        private void DownloadFile(Uri URI, string FilePath)
        {
            FileStream outputStream = new FileStream(FilePath, FileMode.Create);

            Stream FTPReader = CreateDownloadRequest(URI);
            int bufferSize = 1024;
            int readCount;
            byte[] buffer = new byte[bufferSize];

            readCount = FTPReader.Read(buffer, 0, bufferSize);
            while (readCount > 0)
            {
                outputStream.Write(buffer, 0, readCount);
                readCount = FTPReader.Read(buffer, 0, bufferSize);
            }

            outputStream.Close();
            FTPReader.Close();
            FTPReader.Dispose();
        }

        private void LoadInfo(Uri URI)
        {
            Stream outputStream = new MemoryStream();
            Stream FTPReader = CreateDownloadRequest(URI);
            int bufferSize = 1024;
            int readCount;
            byte[] buffer = new byte[bufferSize];

            readCount = FTPReader.Read(buffer, 0, bufferSize);
            while (readCount > 0)
            {
                //outputStream.Write(buffer, 0, readCount);
                AboutAppBox.Text += Encoding.UTF8.GetString(buffer, 0, bufferSize);
                readCount = FTPReader.Read(buffer, 0, bufferSize);
            }

            outputStream.Close();
            FTPReader.Close();
            FTPReader.Dispose();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            this.Text = AppName;
            Parameters.CurrentURI = new Uri(Parameters.AppURI.ToString() + "/Info.txt");
            try
            {
                LoadInfo(Parameters.CurrentURI);
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
