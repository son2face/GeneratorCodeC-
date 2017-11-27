using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorCode.Model;

namespace GeneratorCode.Interface
{
    public interface IParseModelService
    {
        List<PropertyModel> Parse(List<string> InputList);
    }
}