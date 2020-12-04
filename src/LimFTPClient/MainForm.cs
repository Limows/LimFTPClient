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
            SystemsBox.DataSource = null;
            SystemsBox.Items.Clear();
            SystemsBox.Items.AddRange(FTP.ReadListing(Parameters.CurrentURI).ToArray());
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
                Parameters.SystemURI = new Uri(Parameters.ServerURI, SystemsBox.Text);
                Parameters.CurrentURI = Parameters.SystemURI;
                //MessageBox.Show(Parameters.CurrentURI.ToString());

                try
                {
                    SystemsBox.DataSource = null;
                    SystemsBox.Items.Clear();
                    SystemsBox.Items.AddRange(FTP.ReadListing(Parameters.CurrentURI).ToArray());
                }
                catch
                {
                    MessageBox.Show("Ошибка в структуре", "Ошибка");
                    label1.Text = "Выберите нужную систему";
                    SystemsBox.DataSource = null;
                    SystemsBox.Items.Clear();
                    SystemsBox.Items.AddRange(FTP.ReadListing(Parameters.ServerURI).ToArray());
                }
            }
            else
            {
                Parameters.AppURI = new Uri(Parameters.CurrentURI.ToString() + "/" + SystemsBox.Text);
                Parameters.CurrentURI = Parameters.AppURI;
                //MessageBox.Show(Parameters.CurrentURI.ToString());
                AppForm NewAppForm = new AppForm(SystemsBox.Text);
                NewAppForm.ShowDialog();
            }
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
