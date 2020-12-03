using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
