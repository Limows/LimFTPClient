using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Reflection;
using System.IO;

namespace LimFTPClient
{
    class IO
    {
        static public void LoadParameters()
        {
            if (Parameters.ConfigPath == "")
            {
                Parameters.ConfigPath = IO.GetCurrentDirectory();
            }

            FileInfo ConfigFile = new FileInfo(Parameters.ConfigPath);

            BinaryReader Reader = new BinaryReader(ConfigFile.OpenRead());

            Parameters.DownloadPath = Reader.ReadString();

            Reader.Close();
        }

        static public string GetCurrentDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\Default.cfg";
        }

        static public void SaveParameters()
        {
            if (Parameters.ConfigPath == "")
            {
                Parameters.ConfigPath = IO.GetCurrentDirectory();
            }

            FileInfo ConfigFile = new FileInfo(Parameters.ConfigPath);

            if (Parameters.DownloadPath != null)
            {
                BinaryWriter Writer;

                if (!File.Exists(Parameters.ConfigPath))
                {
                    Writer = new BinaryWriter(ConfigFile.Open(FileMode.Create));
                }
                else Writer = new BinaryWriter(ConfigFile.Open(FileMode.Open));

                Writer.Write(Parameters.DownloadPath);

                Writer.Close();
            }
        }

        static public void RemoveParameters()
        {
            if (Parameters.ConfigPath == "")
            {
                Parameters.ConfigPath = IO.GetCurrentDirectory();
            }

            File.Delete(Parameters.ConfigPath);

        }
    }
}