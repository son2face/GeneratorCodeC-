using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneratorCode.Interface;
using GeneratorCode.Model;
using GeneratorCode.Service;

namespace GeneratorCode
{
    public partial class Main : Form
    {
        public readonly IFileService FileService = new FileService();
        public readonly IModuleService ModuleService = new ModuleService();
        public readonly IParseModelService ParseModelService = new ParseModelService();
        public IWriterModuleBackendService WriterModuleBackendService;
        public IWriterModuleFrontEndService WriterModuleFrontEndService;

        public Main()
        {
            InitializeComponent();
        }

        private void UrlBtn_Click(object Sender, EventArgs E)
        {
            if (OpenModelsFolder.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    UrlTb.Text = OpenModelsFolder.SelectedPath;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void GetModuleBtn_Click(object Sender, EventArgs E)
        {
            StatusLb.Text = "Đang tải...";
            var FileInfos = FileService.ReadAllModuleFromModel(UrlTb.Text);
            ModuleService.Create(FileInfos);
            ModuleService.Delete(EntityTb.Text);
            Console.WriteLine("Done");
            StatusLb.Text = "";
        }

        private void ModuleBtn_Click(object Sender, EventArgs E)
        {
            if (OpenModulesFolder.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BackendFolderTb.Text = OpenModulesFolder.SelectedPath;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void CreateFolderFrontEndBtn_Click(object Sender, EventArgs E)
        {
            foreach (var ModuleModel in ModuleService.Get())
            {
                var Dir = $@"{FrontEndFolderTb.Text}\{ModuleModel.Name}";
                Directory.CreateDirectory(Dir);
                FileService.Create($@"{Dir}\{ModuleModel.Name}.Entity.ts",
                    GenerateFrontendTemplate(FileService.ReadFile(@"FrontendTemplate\Template.Entity"), ModuleModel));
                FileService.Create($@"{Dir}\{ModuleModel.Name}.Service.ts",
                    GenerateFrontendTemplate(FileService.ReadFile(@"FrontendTemplate\Template.Service"), ModuleModel));
//                FileService.Create($@"{Dir}\{ModuleModel.Name}.Interface.ts",
//                    GenerateFrontendTemplate(FileService.ReadFile(@"FrontendTemplate\Template.Interface"),
//                        ModuleModel));
                FileService.Create($@"{Dir}\{ModuleModel.Name}.SearchEntity.ts",
                    GenerateFrontendTemplate(FileService.ReadFile(@"FrontendTemplate\Template.SearchEntity"),
                        ModuleModel));
                FileService.Create($@"{Dir}\{ModuleModel.Name}.Component.ts",
                    GenerateFrontendTemplate(FileService.ReadFile(@"FrontendTemplate\Template.Component"),
                        ModuleModel));
                FileService.Create($@"{Dir}\{ModuleModel.Name}.Component.html",
                    GenerateFrontendTemplate(FileService.ReadFile(@"FrontendTemplate\Template.Html"), ModuleModel));
                FileService.Create($@"{Dir}\{ModuleModel.Name}.Component.css",
                    GenerateFrontendTemplate(FileService.ReadFile(@"FrontendTemplate\Template.Css"), ModuleModel));
                FileService.Create($@"{Dir}\{ModuleModel.Name}.Component.spec.ts",
                    GenerateFrontendTemplate(FileService.ReadFile(@"FrontendTemplate\Template.Test"), ModuleModel));
            }
            Console.WriteLine("Done");
        }

        public string GenerateFrontendTemplate(List<string> Template, ModuleModel ModuleModel)
        {
            var Generation = new Generation(Template);
            Generation.Dictionary.Add("[MODULE]", ModuleModel.Name);
            Generation.Dictionary.Add("[MODULES]", ModuleModel.PluralName);
            foreach (var PropertyModel in ModuleModel.PropertyModels)
            {
                if (PropertyModel.IsVirtual)
                {
                    if (PropertyModel.Type.Contains("ICollection"))
                    {
                        var Type = PropertyModel.Type.Split('<')[1].Split('>')[0];
                        Generation.Arraypropertities.Add(LanguageProcessService.ToSingle(PropertyModel.Name), Type);
                    }
                    else
                    {
                        try
                        {
                            Generation.Objectpropertities.Add(PropertyModel.Type, PropertyModel.Type);
                        }
                        catch (Exception e)
                        {
                        }
                    }
                }
                else
                {
                    string Type;
                    switch (PropertyModel.Type)
                    {
                        case "long":
                        case "int":
                            Type = "number";
                            break;
                        default:
                            Type = "string";
                            break;
                    }
                    Generation.Primitivepropertities.Add(PropertyModel.Name, Type);
                }
            }
            return Generation.Analysis();
        }

        public string GenerateBackendTemplate(List<string> Template, ModuleModel ModuleModel, string NameSpace,
            string Entity, string Prefix)
        {
            var Generation = new Generation(Template);
            Generation.Dictionary.Add("[MODULE]", ModuleModel.Name);
            Generation.Dictionary.Add("[MODULES]", ModuleModel.PluralName);
            Generation.Dictionary.Add("[NAMESPACE]", NameSpace);
            Generation.Dictionary.Add("[ENTITY]", Entity);
            Generation.Dictionary.Add("[MODULEPREFIX]", Prefix);
            foreach (var PropertyModel in ModuleModel.PropertyModels)
            {
                if (PropertyModel.IsVirtual)
                {
                    if (PropertyModel.Type.Contains("ICollection"))
                    {
                        var Type = PropertyModel.Type.Split('<')[1].Split('>')[0];
                        Generation.Arraypropertities.Add(LanguageProcessService.ToSingle(PropertyModel.Name), Type);
                    }
                    else
                    {
                        try
                        {
                            Generation.Objectpropertities.Add(PropertyModel.Type, PropertyModel.Type);
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                else
                {
                    Generation.Primitivepropertities.Add(PropertyModel.Name, PropertyModel.Type);
                }
            }
            return Generation.Analysis();
        }

        private void CreateFolderBackEndBtn_Click(object Sender, EventArgs E)
        {
            foreach (var ModuleModel in ModuleService.Get())
            {
                var Dir = $@"{BackendFolderTb.Text}\{PrefixTb.Text}{ModuleModel.Name}";
                Directory.CreateDirectory(Dir);
                FileService.Create($@"{Dir}\{ModuleModel.Name}Controller.cs",
                    GenerateBackendTemplate(FileService.ReadFile(@"BackendTemplate\Template.Controller"),
                        ModuleModel, NameSpaceTb.Text, EntityTb.Text, PrefixTb.Text));
                FileService.Create($@"{Dir}\{ModuleModel.Name}Service.cs",
                    GenerateBackendTemplate(FileService.ReadFile(@"BackendTemplate\Template.Service"), ModuleModel,
                        NameSpaceTb.Text, EntityTb.Text, PrefixTb.Text));
                FileService.Create($@"{Dir}\I{ModuleModel.Name}Service.cs",
                    GenerateBackendTemplate(FileService.ReadFile(@"BackendTemplate\Template.Interface"),
                        ModuleModel, NameSpaceTb.Text, EntityTb.Text, PrefixTb.Text));
                FileService.Create($@"{Dir}\Search{ModuleModel.Name}Entity.cs",
                    GenerateBackendTemplate(FileService.ReadFile(@"BackendTemplate\Template.SearchEntity"),
                        ModuleModel, NameSpaceTb.Text, EntityTb.Text, PrefixTb.Text));
                FileService.Create($@"{Dir}\{ModuleModel.Name}Entity.cs",
                    GenerateBackendTemplate(FileService.ReadFile(@"BackendTemplate\Template.Entity"), ModuleModel,
                        NameSpaceTb.Text, EntityTb.Text, PrefixTb.Text));
            }
            Console.WriteLine("Done!");
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void ChooseFileAppModule_Click(object sender, EventArgs e)
        {
            if (OpenAppModuleFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    AppModuleFileTb.Text = OpenAppModuleFile.FileName;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void ChooseFolderFrontEndBtn_Click(object sender, EventArgs e)
        {
            if (OpenModulesFolder.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FrontEndFolderTb.Text = OpenModulesFolder.SelectedPath;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void UpdateAppModuleBtn_Click(object sender, EventArgs e)
        {
            var Lines = FileService.ReadFile(AppModuleFileTb.Text);
            var Result = "";
            for (var i = 0; i < Lines.Count; i++)
            {
                if (Lines[i].Contains("[IMPORT MODULE]"))
                {
                    Result += Lines[i] + "\n";
                    i++;
                    var Temp = Lines[i].Replace(@"//", "");
                    Result += Lines[i] + "\n";
                    foreach (var ModuleModel in ModuleService.Get())
                    {
                        var Temp1 = Temp.Replace("[MODULE]", ModuleModel.Name);
                        Result += Temp1.Replace("[MODULES]", ModuleModel.PluralName);
                    }
                    Result += Lines[i] + "\n";
                    for (; i < Lines.Count && !Lines[i].Contains("[END]"); i++)
                    {
                    }
                    Result += Lines[i] + "\n";
                }
                else
                {
                    Result += Lines[i] + "\n";
                }
            }
            FileService.Create(AppModuleFileTb.Text, Result);
            Console.WriteLine("Done!!!!");
        }

        private void RouteFile_Click(object sender, EventArgs e)
        {
            if (OpenModulesFolder.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    RouteFileTb.Text = OpenModulesFolder.SelectedPath;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void UpdateRouteFile_Click(object sender, EventArgs e)
        {
            var Lines = FileService.ReadFile(RouteFileTb.Text);
            var Result = "";
            for (var i = 0; i < Lines.Count; i++)
            {
                if (Lines[i].Contains("[IMPORT MODULE]"))
                {
                    Result += Lines[i] + "\n";
                    i++;
                    var Temp = Lines[i].Replace(@"//", "");
                    Result += Lines[i] + "\n";
                    foreach (var ModuleModel in ModuleService.Get())
                    {
                        var Temp1 = Temp.Replace("[MODULE]", ModuleModel.Name);
                        Result += Temp1.Replace("[MODULES]", ModuleModel.PluralName) + "\n";
                    }
                    Result += Lines[i] + "\n";
                    for (; i < Lines.Count && !Lines[i].Contains("[END]"); i++)
                    {
                    }
                    Result += Lines[i] + "\n";
                }
                else
                {
                    Result += Lines[i] + "\n";
                }
            }
            FileService.Create(RouteFileTb.Text, Result);
            Console.WriteLine("Done!!!!");
        }

        private void ModeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ModeCb.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
            }
        }
    }
}