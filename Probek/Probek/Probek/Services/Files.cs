using Probek.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Probek.Services
{
    public class Files
    {
        public string OpenFile(string filePath)
        {
            if (System.IO.File.Exists(filePath))
                return System.IO.File.ReadAllText(filePath);
            throw new Exception();
        }

        public void CreateFile(string filePath, string file, string contents)
        {
            using (TextWriter tw = new StreamWriter(filePath + file))
            {
                tw.WriteLine(contents);
                tw.Close();
            }
        }

        public void EditFile(string filePath, string contents)
        {

        }

        public FileObject GetFileInfo(string path)
        {
            return null;
        }
        
        public string[] GetFolderContents(string path)
        {
            return Directory.GetFiles(path);
        }

        public void CopyMoveFolder(DirectoryInfo target, DirectoryInfo source)
        {
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = Path.Combine(Environment.SystemDirectory, "xcopy.exe");
            proc.StartInfo.Arguments = source.FullName + " " + target.FullName + @" /E /I";
            proc.Start();
        }
    }
}
