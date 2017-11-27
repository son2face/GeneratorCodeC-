using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorCode.Model
{
    public class ModuleModel
    {
        public ModuleModel()
        {
        }
        public string Name { get; set; }
        public string PluralName { get; set; }
        public List<PropertyModel> PropertyModels { get; set; }
    }
}