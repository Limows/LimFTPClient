using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace LimFTPClient
{
    class FTP
    {
        static public Stream CreateDownloadRequest(Uri URI)
        {
            FtpWebRequest FTPRequest = (FtpWebRequest)WebRequest.Create(URI);
            FTPRequest.UseBinary = true;
            FTPRequest.KeepAlive = false;
            FTPRequest.Credentials = new NetworkCredential("anon", "");
            FTPRequest.Method = WebRequestMethods.Ftp.DownloadFile;

            FtpWebResponse Response = (FtpWebResponse)FTPRequest.GetResponse();
            return Response.GetResponseStream();
        }

        static public void DownloadFile(Uri URI, string FilePath)
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

        static public void LoadInfo(Uri URI)
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
                //AboutAppBox.Text += Encoding.UTF8.GetString(buffer, 0, bufferSize);
                readCount = FTPReader.Read(buffer, 0, bufferSize);
            }

            outputStream.Close();
            FTPReader.Close();
            FTPReader.Dispose();
        }

        static public Stream CreateListingRequest(Uri URI)
        {
            FtpWebRequest FTPRequest = (FtpWebRequest)WebRequest.Create(URI);
            FTPRequest.UseBinary = true;
            FTPRequest.KeepAlive = false;
            FTPRequest.Credentials = new NetworkCredential("anon", "");
            FTPRequest.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse Response = (FtpWebResponse)FTPRequest.GetResponse();

            return Response.GetResponseStream();
        }

        static public void ReadListing(Uri URI)
        {
            //SystemsBox.DataSource = null;
            //SystemsBox.Items.Clear();

            StreamReader FTPReader = new StreamReader(CreateListingRequest(URI));

            string line = FTPReader.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                if (line.IndexOf('.') != -1)
                {
                    //MessageBox.Show("Ошибка в структуре", "Ошибка");
                    //label1.Text = "Выберите нужную систему";
                    ReadListing(Parameters.ServerURI);
                    Parameters.CurrentURI = Parameters.ServerURI;
                    break;
                }

                //SystemsBox.Items.Add(line);
                line = FTPReader.ReadLine();
            }

            FTPReader.Close();
            FTPReader.Dispose();
        }
    }
}
