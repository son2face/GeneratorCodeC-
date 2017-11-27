using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorCode.Model;

namespace GeneratorCode.Interface
{
    public interface IWriterModuleBackendService
    {
        string GenerateEntity(ModuleModel ModuleModel, string NameSpace, string Entity, string Prefix);
        string GenerateService(ModuleModel ModuleModel, string NameSpace, string Entity, string Prefix);
        string GenerateInterface(ModuleModel ModuleModel, string NameSpace, string Entity, string Prefix);
        string GenerateController(ModuleModel ModuleModel, string NameSpace, string Entity, string Prefix);
        string GenerateSearchEntity(ModuleModel ModuleModel, string NameSpace, string Entity, string Prefix);
    }
}