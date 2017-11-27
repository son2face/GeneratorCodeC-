using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorCode.Model;

namespace GeneratorCode.Interface
{
    public interface IFileService
    {
        IEnumerable<FileInfo> ReadAllModuleFromModel(string Url);
        List<string> ReadFile(string Url);
        string ReadFileToEnd(string Url);
        void Create(string Url, string Data);
    }
}