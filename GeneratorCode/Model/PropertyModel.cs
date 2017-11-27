using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorCode.Model
{
    public class PropertyModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsVirtual { get; set; }
    }
}