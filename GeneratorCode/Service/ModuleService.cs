using System.Collections.Generic;
using System.IO;
using System.Linq;
using GeneratorCode.Interface;
using GeneratorCode.Model;

namespace GeneratorCode.Service
{
    public class ModuleService : IModuleService
    {
        public List<ModuleModel> ModuleModels = new List<ModuleModel>();
        public IFileService FileService = new FileService();
        public LanguageProcessService LanguageProcessService = new LanguageProcessService();
        public readonly IParseModelService ParseModelService = new ParseModelService();

        public ModuleService()
        {
        }

        public ModuleService(IEnumerable<FileInfo> FileInfos)
        {
            Create(FileInfos);
        }

        public void Create(IEnumerable<FileInfo> FileInfos)
        {
            ModuleModels = FileInfos
                .Select(X => new ModuleModel
                {
                    Name = X.Name.Split('.')[0],
                    PluralName = LanguageProcessService.ToPlural(X.Name.Split('.')[0]),
                    PropertyModels = ParseModelService.Parse(
                        FileService.ReadFile(X.FullName))
                })
                .ToList();
        }
        public void Delete(string Name)
        {
            ModuleModels.Remove(ModuleModels.FirstOrDefault(X => X.Name.Contains(Name)));
        }
        public List<ModuleModel> Get()
        {
            return ModuleModels;
        }
    }
}