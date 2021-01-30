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
using System.Diagnostics;

namespace LimFTPClient
{
    public partial class AppForm : Form
    {
        private string AppName;

        public AppForm(string CurrentAppName)
        {
            InitializeComponent();

            AppName = CurrentAppName;

            DownloadingTimer.Enabled = false;
            DownloadingTimer.Interval = 100;

            if (this.Width == 480)
            {
                LogoBox.Width = 100;
                LogoBox.Height = 100;
            }
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            ParamsHelper.CurrentURI = ParamsHelper.AppURI;

            if (!String.IsNullOrEmpty(ParamsHelper.DownloadPath))
            {
                ThreadStart DownloadingStarter = delegate { DownloadingThreadWorker(ParamsHelper.CurrentURI, ParamsHelper.DownloadPath, ParamsHelper.InstallPath, AppName);  };
                Thread DownloadingThread = new Thread(DownloadingStarter);
                ParamsHelper.IsThreadAlive = true;
                ParamsHelper.IsThreadError = false;

                DownloadingThread.Start();

                StatusLabel.Text = ParamsHelper.ThreadMessage;

                DownloadingTimer.Enabled = true;
                DownloadButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Отсутствует путь для сохранения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }

        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            this.Text = AppName.Replace("_", " ");
            //string InfoFileName = AppName + ".info";
            NameLabel.Text = AppName.Replace("_", " ");
            StatusLabel.Text = "";

            ParamsHelper.CurrentURI = ParamsHelper.AppURI;

            //ThreadStart AppStarter = delegate { FTPHelper.ReadListing(ParamsHelper.CurrentURI); };
            //Thread ListingThread = new Thread(ListingStarter);
            //ListingThread.Start();
            //ParamsHelper.IsThreadAlive = true;

            try
            {
                //AboutAppBox.Text = FTPHelper.LoadInfo(ParamsHelper.CurrentURI);
                SizeLabel.Text = NetHelper.LoadInfo(ParamsHelper.CurrentURI, AppName);
            }
            catch
            {
                SizeLabel.Text = "0 МБ";
            }

            AboutAppBox.Text = "Для этого приложения ещё нет описания";

            ParamsHelper.CurrentURI = ParamsHelper.AppURI;

            Cursor.Current = Cursors.Default;
        }

        private void AppForm_FormClosing(object sender, CancelEventArgs e)
        {
            ParamsHelper.CurrentURI = ParamsHelper.SystemURI;
        }

        private void DownloadingThreadWorker(Uri CurrentURI, string DownloadPath, string InstallPath, string AppName)
        {   
            string FileName = AppName + ".zip";
            bool IsInstalled = false;

            ParamsHelper.ThreadMessage = "Идёт загрузка";

            try
            {
                NetHelper.DownloadFile(CurrentURI, DownloadPath, FileName);
            }
            catch(Exception NewEx)
            {
                ParamsHelper.ThreadException = NewEx;
                ParamsHelper.IsThreadAlive = false;
                ParamsHelper.IsThreadError = true;
                ParamsHelper.ThreadMessage = "Ошибка при загрузке";
                return;
            }

            ParamsHelper.IsThreadWaiting = true;
            ParamsHelper.ThreadMessage = "Успешно загружено";

            while (ParamsHelper.IsThreadWaiting)
            {

            }

            if (ParamsHelper.ThreadMessage == "Yes")
            {   
                ParamsHelper.ThreadMessage = "Идёт распаковка";

                string ExtractedPath;

                try
                {
                    ExtractedPath = IO.ExtractToDirectory(DownloadPath + "\\" + FileName, DownloadPath + "\\" + AppName);
                }
                catch(Exception NewEx)
                {
                    ParamsHelper.ThreadException = NewEx;
                    ParamsHelper.IsThreadAlive = false;
                    ParamsHelper.IsThreadError = true;
                    ParamsHelper.ThreadMessage = "Ошибка при распаковке";
                    return;
                }

                ParamsHelper.ThreadMessage = "Успешно распаковано";

                if (!String.IsNullOrEmpty(InstallPath))
                {   
                    ParamsHelper.ThreadMessage = "Идёт установка";

                    try
                    {
                        IsInstalled = Sys.AppInstall(ExtractedPath, InstallPath, AppName, ParamsHelper.IsOverwrite);
                    }
                    catch(Exception NewEx)
                    {
                        ParamsHelper.ThreadException = NewEx;
                        ParamsHelper.IsThreadAlive = false;
                        ParamsHelper.IsThreadError = true;
                        ParamsHelper.ThreadMessage = "Ошибка при установке";
                        return;  
                    }

                    if (IsInstalled) ParamsHelper.ThreadMessage = "Успешно установлено";
                    else ParamsHelper.ThreadMessage = "Ошибка при установке";
                }
                else
                {
                    ParamsHelper.ThreadException = new Exception("InstallPath Empty");
                    ParamsHelper.IsThreadAlive = false;
                    ParamsHelper.IsThreadError = true;
                    ParamsHelper.ThreadMessage = "Ошибка при установке";
                    return;  
                }

            }

            ParamsHelper.CurrentURI = ParamsHelper.AppURI;
            ParamsHelper.IsThreadAlive = false;
        }

        private void DownloadingTimer_Tick(object sender, EventArgs e)
        {
            if (!ParamsHelper.IsThreadAlive)
            {
                DownloadingTimer.Enabled = false;
                DownloadButton.Enabled = true;
                StatusLabel.Text = ParamsHelper.ThreadMessage;

                if (ParamsHelper.IsThreadError)
                {
                    try
                    {
                        throw ParamsHelper.ThreadException;
                    }
                    catch (UnauthorizedAccessException)
                    {
                        MessageBox.Show("Невозможно сохранить в " + ParamsHelper.DownloadPath + "\nВозможно программа должна быть\nзапущена от имени администратора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Невозможно сохранить в " + ParamsHelper.DownloadPath + "\nВыберите другую директорию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }
                    catch (WebException)
                    {
                        MessageBox.Show("Невозможно подключиться к серверу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }
                    catch (Exception NewEx)
                    {
                        if (NewEx.Message == "InstallPath Empty")
                        {
                            MessageBox.Show("Отсутствует путь для установки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при установке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        }
                    }

                }

            }
            else
            {
                StatusLabel.Text = ParamsHelper.ThreadMessage;

                if (ParamsHelper.IsThreadWaiting)
                {
                    DownloadingTimer.Enabled = false;
                    if (!ParamsHelper.IsAutoInstall)
                    {
                        DialogResult Result = MessageBox.Show("Установить?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                        if (Result == DialogResult.Yes)
                        {
                            ParamsHelper.ThreadMessage = "Yes";
                        }
                    }
                    else
                    {
                        ParamsHelper.ThreadMessage = "Yes";
                    }

                    DownloadingTimer.Enabled = true;
                    ParamsHelper.IsThreadWaiting = false;
                }
            }             
        }
    }
}