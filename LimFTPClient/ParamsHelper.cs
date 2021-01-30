using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using System.Threading;

namespace LimFTPClient
{
    class ParamsHelper
    {   

        static public Uri ServerURI = new Uri("ftp://anon@limowski.xyz:2121");
        static public Uri CurrentURI;
        static public Uri SystemURI;
        static public Uri AppURI;
        static public string DownloadPath;
        static public string InstallPath;
        static public string ConfigPath;
        static public string OSVersion;
        static public List<string> AppsList;
        static public EventWaitHandle ThreadEvent;
        static public bool IsThreadAlive;
        static public bool IsThreadError;
        static public bool IsThreadWaiting;
        static public Exception ThreadException;
        static public string ThreadMessage;
        static public bool IsAutoInstall;
        static public bool IsRmPackage;
        static public bool IsOverwrite;
        
        /*
        public enum OSVersions
        {
            WinMobile5 = "WinMobile_5",
            WinMobile2003 = "WinMobile_2003"
        }
         */

        /// <summary>
        /// Convert bytes to megabytes
        /// </summary>
        /// <param name="Bytes"></param>
        /// <returns>Megabytes</returns> 
        static public double BytesToMegs(ulong Bytes)
        {
            return ((double)Bytes / 1024) / 1024;
        }

    }
}
