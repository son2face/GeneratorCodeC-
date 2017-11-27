using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorCode.Model;

namespace GeneratorCode.Interface
{
    public interface IWriterModuleFrontEndService
    {
        string GenerateEntity(ModuleModel ModuleModel);
        string GenerateService(ModuleModel ModuleModel);
        string GenerateInterface(ModuleModel ModuleModel, string NameSpace, string Entity, string Prefix);
        string GenerateController(ModuleModel ModuleModel, string NameSpace, string Entity, string Prefix);
        string GenerateSearchEntity(ModuleModel ModuleModel, string NameSpace, string Entity, string Prefix);
    }
}