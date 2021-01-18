using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Reflection;
using System.IO;
using System.IO.Compression;

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

        public static void ExtractToDirectory(string CompressedFilePath, string ExtractedFilePath)
        {
            FileInfo fileToDecompress = new FileInfo(CompressedFilePath);

            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                //string currentFileName = fileToDecompress.FullName;
                string newFileName = ExtractedFilePath;

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        //decompressionStream.CopyTo(decompressedFileStream);
                        CopyTo(decompressionStream, decompressedFileStream, 8192);
                        //Console.WriteLine($"Decompressed: {fileToDecompress.Name}");
                    }
                }
            }
        }

        private static void CopyTo(Stream source, Stream destination, int bufferSize)
        {
            byte[] array = new byte[bufferSize];
            int count;

            while ((count = source.Read(array, 0, array.Length)) != 0)
            {
                destination.Write(array, 0, count);
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