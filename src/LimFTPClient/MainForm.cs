using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace LimFTPClient
{
    public partial class MainForm : Form
    {

        public MainForm()
        {   
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Выберите нужную систему";
            Parameters.CurrentURI = Parameters.ServerURI;
            ReadListing(Parameters.CurrentURI);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SystemsBox_Click(object sender, EventArgs e)
        {

        }

        private void SystemsBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label1.Text = "Выберите нужное приложение";
            if (Parameters.CurrentURI == Parameters.ServerURI)
            {   
                Parameters.SystemURI = new Uri(Parameters.ServerURI.ToString() + SystemsBox.Text);
                //DownloadFile(Parameters.CurrentURI, "E:\\");
                Parameters.CurrentURI = Parameters.SystemURI;
                ReadListing(Parameters.CurrentURI);
            }
            else
            {
                Parameters.AppURI = new Uri(Parameters.CurrentURI.ToString() + "/" + SystemsBox.Text);
                Parameters.CurrentURI = Parameters.AppURI;
                AppForm NewAppForm = new AppForm(SystemsBox.Text);
                NewAppForm.ShowDialog();
            }
        }

        private Stream CreateListingRequest (Uri URI)
        {
            FtpWebRequest FTPRequest = (FtpWebRequest)WebRequest.Create(URI);
            FTPRequest.UseBinary = true;
            FTPRequest.KeepAlive = false;
            FTPRequest.Credentials = new NetworkCredential("anon", "");
            FTPRequest.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse Response = (FtpWebResponse)FTPRequest.GetResponse();

            return Response.GetResponseStream();
        }

        private void ReadListing(Uri URI)
        {
            SystemsBox.DataSource = null;
            SystemsBox.Items.Clear();

            StreamReader FTPReader = new StreamReader(CreateListingRequest(URI));

            string line = FTPReader.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                if (line.IndexOf('.') != -1)
                {
                    MessageBox.Show("Ошибка в структуре", "Ошибка");
                    label1.Text = "Выберите нужную систему";
                    ReadListing(Parameters.ServerURI);
                    Parameters.CurrentURI = Parameters.ServerURI;
                    break;
                }

                SystemsBox.Items.Add(line);
                line = FTPReader.ReadLine();
            }

            FTPReader.Close();
            FTPReader.Dispose();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Версия 0.1\nСборка от 03.12.20", "О программе");
            AboutBox NewAboutBox = new AboutBox();
            NewAboutBox.Show();
        }

        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParamsBox NewParamsBox = new ParamsBox();
            NewParamsBox.ShowDialog();
        }
    }
}
