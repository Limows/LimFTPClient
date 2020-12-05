using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LimFTPClient
{
    class IO
    {
        static public void LoadParameters()
        {
            FileInfo ConfigFile = new FileInfo(Parameters.ConfigPath);

            BinaryReader Reader = new BinaryReader(ConfigFile.OpenRead());

            Parameters.DownloadPath = Reader.ReadString();

            Reader.Dispose();
            Reader.Close();
        }

        static public void SaveParameters()
        {
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

                Writer.Dispose();
                Writer.Close();
            }
        }

        static public void RemoveParameters()
        {

            File.Delete(Parameters.ConfigPath);

        }
    }
}
