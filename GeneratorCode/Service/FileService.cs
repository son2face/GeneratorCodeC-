using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GeneratorCode.Interface;

namespace GeneratorCode.Service
{
    public class FileService : IFileService
    {
        public IEnumerable<FileInfo> ReadAllModuleFromModel(string Url)
        {
            var D = new DirectoryInfo(Url); //Assuming Test is your Folder
            var Files = D.GetFiles("*.cs")
                .Where(X => X.Name.Split('.').Length == 2 && !"sysdiagram.cs".Equals(X.Name)); //Getting Text files
            return Files;
        }

        public List<string> ReadFile(string Url)
        {
            var File = new StreamReader(Url);
            var Result = new List<string>();
            string Line;
            while ((Line = File.ReadLine()) != null)
            {
                Result.Add(Line);
            }
            File.Close();
            return Result;
        }

        public string ReadFileToEnd(string Url)
        {
            try
            {
                var File = new StreamReader(Url);
                var Result = File.ReadToEnd();
                File.Close();
                return Result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public void Create(string Url, string Data)
        {
            var File = new StreamWriter(Url);
            File.Write(Data);
            File.Close();
        }
    }
}