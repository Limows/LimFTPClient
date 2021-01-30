using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using WinMobileNetCFExt.About;

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

            RegisterMenuItem.Enabled = false;
            PropButton.Enabled = false;
            DeleteButton.Enabled = false;
            ListingThreadTimer.Enabled = false;
            ListingThreadTimer.Interval = 10;

            AboutBox NewAboutBox = new AboutBox();

            this.Text = NewAboutBox.AssemblyTitle;
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для выбора приложения кликните по его названию в списке", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox NewAboutForm = new AboutBox();
            NewAboutForm.ShowDialog();
        }

        private void BackMenuItem_Click(object sender, EventArgs e)
        {
            GetAppsList();

            Connect();
        }

        private void ParamsMenuItem_Click(object sender, EventArgs e)
        {
            ParamsForm NewParamsBox = new ParamsForm();
            NewParamsBox.ShowDialog();
        }

        private void MainForm_Closing(object sender, CancelEventArgs e)
        {
            IO.SaveParameters();
        }

        private void Connect()
        {
            ParamsHelper.CurrentURI = ParamsHelper.SystemURI;
            ParamsHelper.ThreadEvent = new AutoResetEvent(false);
            ThreadStart ListingStarter = delegate { NetHelper.ReadListing(ParamsHelper.CurrentURI); };
            Thread ListingThread = new Thread(ListingStarter);
            ParamsHelper.IsThreadAlive = true;
            ParamsHelper.IsThreadError = false;
           
            ListingThread.Start();

            ListingThreadTimer.Enabled = true;

        }

        private void ConnectionStatusLabel_ParentChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int MajorOSVersion = Environment.OSVersion.Version.Major;

            if (MajorOSVersion == 4) ParamsHelper.OSVersion = "WinMobile_2003";
            else ParamsHelper.OSVersion = "WinMobile_5";

            ParamsHelper.SystemURI = new Uri(ParamsHelper.ServerURI.ToString() + "/" + ParamsHelper.OSVersion);

            GetAppsList();

            Connect();
        }

        private void GetAppsList()
        {   
            InstalledBox.DataSource = null;
            InstalledBox.Items.Clear();

            try
            {
                List<string> InstalledList = new List<string>();
                InstalledList = Sys.GetInstalledApps();

                foreach (string app in InstalledList)
                {
                    InstalledBox.Items.Add(app);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void SystemsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string AppName = AppsBox.Text.Replace(" ", "_");
            ParamsHelper.AppURI = new Uri(ParamsHelper.CurrentURI.ToString() + "/" + AppName);
            ParamsHelper.CurrentURI = ParamsHelper.AppURI;
            //MessageBox.Show(Parameters.CurrentURI.ToString());

            Cursor.Current = Cursors.WaitCursor;

            AppForm NewAppForm = new AppForm(AppName);
            NewAppForm.ShowDialog();

            Cursor.Current = Cursors.Default;

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void PropButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(InstalledBox.Text))
            {
                AboutAppBox NewAboutAppBox = new AboutAppBox(InstalledBox.Text);
                NewAboutAppBox.ShowDialog();
            }
            else
            {
                MessageBox.Show("Приложение не выбрано", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);    
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MemLabel.Text = ParamsHelper.BytesToMegs(IO.GetStorageSpace(ParamsHelper.DownloadPath)).ToString("0.##") + " МБ";
            }
            catch (ArgumentNullException)
            {
                MemLabel.Text = "0 байт";
            }

            PropButton.Enabled = !PropButton.Enabled;
            //RegisterMenuItem.Enabled = !RegisterMenuItem.Enabled;
        }

        private void RegisterMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListingThreadTimer_Tick(object sender, EventArgs e)
        {
            if (!ParamsHelper.IsThreadAlive)
            {
                if (ParamsHelper.IsThreadError)
                {
                    try
                    {
                        throw ParamsHelper.ThreadException;
                    }
                    catch
                    {
                        ListingThreadTimer.Enabled = false;
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Не удалось подключиться к серверу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }

                }
                else
                {
                    AppsBox.DataSource = null;
                    AppsBox.Items.Clear();

                    foreach (string app in ParamsHelper.AppsList)
                    {
                        AppsBox.Items.Add(app);
                    }

                    ListingThreadTimer.Enabled = false;
                    Cursor.Current = Cursors.Default;
                }

            }
            else
            {
                if (Cursor.Current != Cursors.WaitCursor)
                {
                    Cursor.Current = Cursors.WaitCursor;
                }
            }

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void UpdateSysMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox NewAboutBox = new AboutBox();
            string Version = NetHelper.CheckUpdates();
            string CurrentVersion = NewAboutBox.AssemblyVersion;

            MessageBox.Show("Последняя версия: " + Version, "Сообщение");

            /*

            if (CurrentVersion != Version)
            {
                DialogResult Result = MessageBox.Show("Версия: " + Version, "Обновить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (Result == DialogResult.Yes)
                {
                    Version = Version.Remove(Version.LastIndexOf('.'), 2);
                    string Response = FTPHelper.GetUpdates(Version);
                }
            }
            else
            {
                MessageBox.Show("Последняя версия", "Сообщение");   
            }
             */
        }

    }
}