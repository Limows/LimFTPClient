using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading.Tasks;

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

            Stream FTPReader = CreateDownloadRequest(URI);
            FileStream outputStream;

            //FTPReader.Close();

            try
            {
                outputStream = new FileStream(FilePath, FileMode.Create);
            }
            catch
            {
                FTPReader.Dispose();
                FTPReader.Close();

                throw;
            }

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
            FTPReader.Dispose();
            FTPReader.Close();
        }

        static public string LoadInfo(Uri URI)
        {
            Stream FTPReader = CreateDownloadRequest(URI);
            string AppInfo = "";
            int bufferSize = 1024;
            int readCount;
            byte[] buffer = new byte[bufferSize];

            readCount = FTPReader.Read(buffer, 0, bufferSize);
            while (readCount > 0)
            {
                AppInfo += Encoding.UTF8.GetString(buffer, 0, bufferSize);
                readCount = FTPReader.Read(buffer, 0, bufferSize);
            }

            FTPReader.Dispose();
            FTPReader.Close();

            return AppInfo;
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

        static public List<string> ReadListing(Uri URI)
        {
            StreamReader FTPReader = new StreamReader(CreateListingRequest(URI));
            List<string> SystemsList = new List<string>();

            string line = FTPReader.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                if (line.IndexOf('.') != -1)
                {
                    //Parameters.CurrentURI = Parameters.ServerURI;
                    //FTPReader.Close();
                    //FTPReader.Dispose();
                    //throw new Exception("Error in structure");
                }
                else
                {
                    SystemsList.Add(line);
                }

                line = FTPReader.ReadLine();
            }

            FTPReader.Dispose();
            FTPReader.Close();

            if (SystemsList.Count == 0)
            {
                Parameters.CurrentURI = Parameters.ServerURI;
                throw new Exception("Repo is empty");
            }

            return SystemsList;
        }
    }
}
