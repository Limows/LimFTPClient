using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace LimFTPClient
{
    public partial class MainForm : Form
    {

        public MainForm()
        {   
            InitializeComponent();

            try
            {
                IO.LoadParameters();
            }
            catch
            {
                IO.RemoveParameters();
            }

        }

        private void label1_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Репозиторий пуст", "Ошибка");
                    Connect();
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

        private void Connect()
        {
            label1.Text = "Выберите нужную систему";
            ConnectionStatusLabel.Text = "Подключение...";
            Parameters.CurrentURI = Parameters.ServerURI;
            SystemsBox.DataSource = null;
            SystemsBox.Items.Clear();
            try
            {
                SystemsBox.Items.AddRange(FTP.ReadListing(Parameters.CurrentURI).ToArray());
                ConnectionStatusLabel.Text = "Подключено";
            }
            catch
            {
                ConnectionStatusLabel.Text = "Подключение не удалось";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Connect();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void ParamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParamsBox NewParamsBox = new ParamsBox();
            NewParamsBox.ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Версия 0.1\nСборка от 03.12.20", "О программе");
            AboutBox NewAboutBox = new AboutBox();
            NewAboutBox.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для выбора в списке\nиспользуйте двойной щелчок", "Справка");
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SystemsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            IO.SaveParameters();
        }
    }
}
