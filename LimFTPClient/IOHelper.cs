using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;
using System.IO.Compression;
using ICSharpCode.SharpZipLib.Zip;

namespace LimFTPClient
{

    class IOHelper
    {
        [DllImport("coredll.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetDiskFreeSpaceEx(string lpDirectoryName,
        out ulong lpFreeBytesAvailable,
        out ulong lpTotalNumberOfBytes,
        out ulong lpTotalNumberOfFreeBytes);

        /// <summary>
        /// Get storage space
        /// </summary>
        /// <param name="Path"></param>
        /// <returns>Current storage space</returns> 
        public static ulong GetStorageSpace(string Path)
        {
            DriveInfo[] Drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in Drives)
            {
                if (drive.IsReady == true && !String.IsNullOrEmpty(Path))
                {   
                    if (drive.Name == Path.Split('\\')[0] + "\\")
                    {
                        ulong FreeBytes = (ulong)drive.AvailableFreeSpace;

                        return FreeBytes;
                    }

                }
            }

            return 0;
        }

        /// <summary>
        /// Extract zip archive to directory
        /// </summary>
        /// <param name="CompressedFilePath"></param>
        /// <param name="ExtractedFilePath"></param>
        /// <returns>Current storage space</returns> 
        public static string ExtractToDirectory(string CompressedFilePath, string ExtractedFilePath)
        {   
            bool IsDirectory = false;

            ZipFile Archive = new ZipFile(CompressedFilePath);

            foreach (ZipEntry entry in Archive)
            {
                if (entry.IsDirectory)
                {
                    IsDirectory = true;
                    break;
                }
            }

            FastZip ZipArc = new FastZip();
            ZipArc.CreateEmptyDirectories = true;

            ZipArc.ExtractZip(CompressedFilePath, ExtractedFilePath, null);

            Archive.Close();

            if (IsDirectory)
            {   
                string [] Dirs = Directory.GetDirectories(ExtractedFilePath);
                return Dirs[0];
            }

            return ExtractedFilePath;
        }

        static public void LoadParameters()
        {
            if (String.IsNullOrEmpty(ParamsHelper.ConfigPath))
            {
                ParamsHelper.ConfigPath = IOHelper.GetConfigPath();
            }

            FileInfo ConfigFile = new FileInfo(ParamsHelper.ConfigPath);

            using (BinaryReader Reader = new BinaryReader(ConfigFile.OpenRead()))
            {
                ParamsHelper.IsOverwrite = Reader.ReadBoolean();
                ParamsHelper.IsRmPackage = Reader.ReadBoolean();
                ParamsHelper.IsAutoInstall = Reader.ReadBoolean();
                ParamsHelper.DownloadPath = Reader.ReadString();
                ParamsHelper.InstallPath = Reader.ReadString();
            }
        }

        static private string GetConfigPath()
        {   
            return GetCurrentDirectory() + "\\Default.cfg";
        }

        /// <summary>
        /// Get current directory
        /// </summary>
        /// <returns>Current directory path</returns> 
        static public string GetCurrentDirectory()
        {
            return Directory.GetCurrentDirectory();
        }

        static public void SaveParameters()
        {
            if (String.IsNullOrEmpty(ParamsHelper.ConfigPath))
            {
                ParamsHelper.ConfigPath = IOHelper.GetConfigPath();
            }

            FileInfo ConfigFile = new FileInfo(ParamsHelper.ConfigPath);

            if (!String.IsNullOrEmpty(ParamsHelper.DownloadPath) && !String.IsNullOrEmpty(ParamsHelper.InstallPath))
            {
                RemoveParameters();

                using (BinaryWriter Writer = new BinaryWriter(ConfigFile.Open(FileMode.Create)))
                {
                    Writer.Write(ParamsHelper.IsOverwrite);
                    Writer.Write(ParamsHelper.IsRmPackage);
                    Writer.Write(ParamsHelper.IsAutoInstall);
                    Writer.Write(ParamsHelper.DownloadPath);
                    Writer.Write(ParamsHelper.InstallPath);
                }
            }
        }

        static public void RemoveParameters()
        {
            if (String.IsNullOrEmpty(ParamsHelper.ConfigPath))
            {
                ParamsHelper.ConfigPath = IOHelper.GetConfigPath();
            }

            File.Delete(ParamsHelper.ConfigPath);

        }

        public static string GetRemovableStorageDirectory()
        {
            string removableStorageDirectory = null;

            WIN32_FIND_DATA findData = new WIN32_FIND_DATA();
            IntPtr handle = IntPtr.Zero;

            handle = FindFirstFlashCard(ref findData);

            if (handle != INVALID_HANDLE_VALUE)
            {
                do
                {
                    if (!string.IsNullOrEmpty(findData.cFileName))
                    {
                        removableStorageDirectory = findData.cFileName;
                        break;
                    }
                }
                while (FindNextFlashCard(handle, ref findData));
                FindClose(handle);
            }

            return removableStorageDirectory;
        }

        public static readonly IntPtr INVALID_HANDLE_VALUE = (IntPtr)(-1);

        // The CharSet must match the CharSet of the corresponding PInvoke signature
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct WIN32_FIND_DATA
        {
            public int dwFileAttributes;
            public FILETIME ftCreationTime;
            public FILETIME ftLastAccessTime;
            public FILETIME ftLastWriteTime;
            public int nFileSizeHigh;
            public int nFileSizeLow;
            public int dwOID;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string cFileName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
            public string cAlternateFileName;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct FILETIME
        {
            public int dwLowDateTime;
            public int dwHighDateTime;
        };

        [DllImport("note_prj", EntryPoint = "FindFirstFlashCard")]
        public extern static IntPtr FindFirstFlashCard(ref WIN32_FIND_DATA findData);

        [DllImport("note_prj", EntryPoint = "FindNextFlashCard")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public extern static bool FindNextFlashCard(IntPtr hFlashCard, ref WIN32_FIND_DATA findData);

        [DllImport("coredll")]
        public static extern bool FindClose(IntPtr hFindFile);
    }
}
