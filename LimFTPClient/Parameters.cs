using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LimFTPClient
{
    class Parameters
    {
        static public Uri ServerURI = new Uri("ftp://limowski.xyz:2121");
        static public Uri CurrentURI;
        static public Uri SystemURI;
        static public Uri AppURI;
        static public string DownloadPath;
        static public string ConfigPath = "Default.cfg";
    }
}
