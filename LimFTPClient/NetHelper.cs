using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace LimFTPClient
{
    class NetHelper
    {
        static private Stream CreateDownloadRequest(Uri URI)
        {
            FtpWebRequest FTPRequest = (FtpWebRequest)WebRequest.Create(URI);
            FTPRequest.UseBinary = true;
            FTPRequest.KeepAlive = false;
            FTPRequest.Credentials = new NetworkCredential("anon", "");
            FTPRequest.Method = WebRequestMethods.Ftp.DownloadFile;

            FtpWebResponse Response = (FtpWebResponse)FTPRequest.GetResponse();
            return Response.GetResponseStream();
        }

        static private ulong GetFileSizeRequest(Uri URI)
        {
            FtpWebRequest FTPRequest = (FtpWebRequest)FtpWebRequest.Create(URI);
            FTPRequest.UseBinary = true;
            FTPRequest.KeepAlive = false;
            FTPRequest.Credentials = new NetworkCredential("anon", "");
            FTPRequest.Method = WebRequestMethods.Ftp.GetFileSize;

            FtpWebResponse response = (FtpWebResponse)FTPRequest.GetResponse();
            long FileSize = response.ContentLength;
            response.Close();

            return (ulong)FileSize;
        }

        /// <summary>
        /// Retrieves a file from the FTP server
        /// </summary>
        /// <param name="URI"></param>
        /// <param name="DownloadDir"></param>
        /// <param name="FileName"></param>
        static public void DownloadFile(Uri URI, string FilePath, string FileName)
        {
            URI = new Uri(URI.ToString() + "/" + FileName);

            using (Stream FTPReader = CreateDownloadRequest(URI))
            {
                using (FileStream outputStream = new FileStream(FilePath + "\\" + FileName, FileMode.Create))
                {
                    int bufferSize = 1024;
                    int readCount;
                    byte[] buffer = new byte[bufferSize];

                    readCount = FTPReader.Read(buffer, 0, bufferSize);

                    while (readCount > 0)
                    {
                        outputStream.Write(buffer, 0, readCount);
                        readCount = FTPReader.Read(buffer, 0, bufferSize);
                    }
                }
            }

        }

        /// <summary>
        /// Retrieves a package information from the FTP server
        /// </summary>
        /// <param name="URI"></param>
        /// <param name="AppName"></param>
        /// <returns>The file info as a string</returns> 
        static public string LoadInfo(Uri URI, string AppName)
        {
            Uri InfoUri = new Uri(URI.ToString() + "/" + AppName + ".info");
            Uri FileUri = new Uri(URI.ToString() + "/" + AppName + ".zip");
            Uri LogoUri = new Uri(URI.ToString() + "/Logo.png");
            string AppSize = "";
            string AppInfo = "";
            string AppScrShot = null;
            string AppLogo = null;
            int bufferSize = 1024;
            int readCount;
            byte[] buffer = new byte[bufferSize];

            try
            {
                using (Stream FTPReader = CreateDownloadRequest(InfoUri))
                {


                    readCount = FTPReader.Read(buffer, 0, bufferSize);
                    while (readCount > 0)
                    {
                        AppInfo += Encoding.UTF8.GetString(buffer, 0, bufferSize);
                        readCount = FTPReader.Read(buffer, 0, bufferSize);
                    }

                }

            }
            catch
            {
                AppInfo = null;
            }

            try
            {
                AppSize = ParamsHelper.BytesToMegs(GetFileSizeRequest(FileUri)).ToString("0.##") + " МБ";
            }
            catch
            {
                throw;
                AppSize = null;
            }

            return AppSize + "\n" + AppInfo + "\n" + AppLogo + "\n" + AppScrShot;
        }

        static private Stream CreateListingRequest(Uri URI)
        {
            FtpWebRequest FTPRequest = (FtpWebRequest)WebRequest.Create(URI);
            FTPRequest.UseBinary = true;
            FTPRequest.KeepAlive = false;
            FTPRequest.Credentials = new NetworkCredential("anon", "");
            FTPRequest.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse Response = (FtpWebResponse)FTPRequest.GetResponse();

            return Response.GetResponseStream();
        }

        /// <summary>
        /// Retrieves the listing of the files in current directory on FTP server
        /// </summary>
        /// <param name="URI"></param>
        /// <returns>The server file list as a List</returns>
        static public void ReadListing(Uri URI)
        {
            StreamReader FTPReader = new StreamReader(CreateListingRequest(URI));
            ParamsHelper.AppsList = new List<string>();

            string line = FTPReader.ReadLine();

            while (!string.IsNullOrEmpty(line))
            {   

                if (!String.IsNullOrEmpty(line) && line.IndexOf('.') == -1)
                {
                    ParamsHelper.AppsList.Add(line.Replace("_", " "));
                }

                line = FTPReader.ReadLine();

            }

            FTPReader.Dispose();
            FTPReader.Close();

            if (ParamsHelper.AppsList.Count == 0)
            {
                ParamsHelper.IsThreadAlive = false;
                ParamsHelper.IsThreadError = true;
                ParamsHelper.ThreadException = new Exception("Repo is empty");
                return;
            }

            ParamsHelper.IsThreadAlive = false;

        }

        static public string CheckUpdates()
        {
            Uri URI = new Uri("http://limowski.xyz:80/downloads/LimFTPClient/Win9xNT/LimFTPClientVersion.txt");
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(URI);
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
            string ResponseMessage;

            using (StreamReader stream = new StreamReader(Response.GetResponseStream(), Encoding.UTF8))
            {
                ResponseMessage = stream.ReadToEnd();
                ResponseMessage = ResponseMessage.Replace("\n", "");
            }

            return ResponseMessage;
        }

        static public void GetUpdates(string Version)
        {
            Uri URI = new Uri("http://limowski.xyz:80/downloads/LimFTPClient/Win9xNT/LimFTPClient.zip");
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(URI);
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

            using (FileStream UpdateFile = new FileStream(ParamsHelper.DownloadPath + "\\Update.zip", FileMode.Create, FileAccess.Write))
            {
                using (BinaryReader Reader = new BinaryReader(Response.GetResponseStream()))
                {
                    int BufSize = 2048;
                    byte[] Buffer = new byte[BufSize];
                    int Count = 0;

                    while ((Count = Reader.Read(Buffer, 0, BufSize)) > 0)
                    {
                        UpdateFile.Write(Buffer, 0, Count);
                    }
                }
            }
        }

    }
}
