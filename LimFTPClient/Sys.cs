using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Reflection;

namespace LimFTPClient
{
    class Sys
    {
        /// <summary>
        /// Get list of installed apps
        /// </summary>
        /// <returns>List of installed apps</returns> 
        public static List<string> GetInstalledApps()
        {
            string SoftwareKey = "Software\\Apps";
            List<string> AppsList = new List<string>();

            /*
            using (RegistryKey RegKey = Registry.LocalMachine.OpenSubKey(SoftwareKey))
            {

                foreach (string appname in RegKey.GetSubKeyNames())
                {
                    if (appname != "Shared" && appname != "Microsoft Application Installer" && appname != "Customization Tools")
                    {
                        //InstalledBox.Items.Add(appname);
                        AppsList.Add(appname);
                    }
                }
            }
            */
            return AppsList;
        }

        public static string GetInstallDir(string AppName)
        {   
            string SoftwareKey = "Software\\Apps\\" + AppName;
            string InstallDir = "";

            /*

            using (RegistryKey RegKey = Registry.LocalMachine.OpenSubKey(SoftwareKey))
            {
                InstallDir = Convert.ToString(RegKey.GetValue("InstallDir", ""));   
            }
            */

            return InstallDir;
        }

        static public bool AppInstall(string AppPath, string InstallPath, string AppName, bool Overwrite)
        {   
            AppName = AppName.Replace('_', ' ');

            InstallPath = InstallPath + "\\" + AppName;
            bool IsInstalled = false;

            /*

            string[] Cabs = Directory.GetFiles(AppPath, "*.cab");

            if (Cabs.Length == 0)
            {
                IsInstalled = DirInstall(AppPath, InstallPath, AppName, Overwrite);    
            }
            else
            {

                foreach (string cab in Cabs)
                {
                    IsInstalled = CabInstall(cab, InstallPath);
                }
            }

            */

            return IsInstalled;
        }

        static public bool CabInstall(string CabPath, string InstallPath)
        {
            string ConsoleArguments = "/delete 0 /noaskdest ";
            string SoftwareKey = "Software\\Apps\\Microsoft Application Installer";

            using (RegistryKey AppInstallerKey = Registry.LocalMachine.OpenSubKey(SoftwareKey, true))
            {
                using (RegistryKey InstallKey = AppInstallerKey.CreateSubKey("Install"))
                {
                    InstallKey.SetValue(CabPath, InstallPath);

                    //Directory.CreateDirectory(InstallPath);

                    Process InstallProc = new Process();
                    InstallProc.StartInfo.FileName = "\\windows\\wceload.exe";

                    InstallProc.StartInfo.Arguments = ConsoleArguments + "\"" + CabPath + "\"";

                    InstallProc.Start();

                    InstallProc.WaitForExit();

                    InstallKey.DeleteValue(CabPath);
                }
            }

            return true;
        }

        static public bool DirInstall(string DirPath, string InstallPath, string AppName, bool Overwrite)
        {
            string ShortcutName = Environment.GetFolderPath(Environment.SpecialFolder.Programs) + "\\" + AppName + ".lnk";

            if (Directory.Exists(InstallPath))
            {
                if (Overwrite)
                {
                    Directory.Delete(InstallPath, true);
                    Directory.Move(DirPath, InstallPath);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Directory.Move(DirPath, InstallPath);   
            }

            string[] Execs = Directory.GetFiles(InstallPath, "*.exe");

            if (Execs.Length != 1)
            {
                   
            }
            else 
            {
                CreateShortcut(ShortcutName, Execs[0], Overwrite);
            }

            AddToRegistry(AppName, InstallPath);

            return true;

        }

        static public void CreateShortcut(string ShortcutName, string TargetName, bool Overwrite)
        {   
            FileInfo Shortcut = new FileInfo(ShortcutName);

            TextWriter Writer;

            if (!File.Exists(ShortcutName))
            {
                Writer = new StreamWriter(Shortcut.Open(FileMode.Create));
            }
            else
            {
                if (Overwrite)
                {
                    File.Delete(ShortcutName);
                    Writer = new StreamWriter(Shortcut.Open(FileMode.Create));
                }
                else
                {
                    return;
                }
            }

            Writer.Write(TargetName.Length + "#");
            Writer.WriteLine("\"" + TargetName + "\"");

            Writer.Close();
        }

        static public void AddToRegistry(string AppName, string InstallPath)
        {
            string SoftwareKey = "Software\\Apps\\";

            using (RegistryKey RegKey = Registry.LocalMachine.OpenSubKey(SoftwareKey, true))
            {
                using (RegistryKey AppKey = RegKey.CreateSubKey(AppName))
                {
                    AppKey.SetValue("InstallDir", InstallPath);
                    AppKey.SetValue("Instl", 1);
                    AppKey.SetValue("InstlDir", InstallPath);
                }
            }
        }
    }
}
