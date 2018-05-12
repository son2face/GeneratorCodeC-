using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using GeneratorCode.Interface;
using GeneratorCode.Model;

namespace GeneratorCode.Service
{
    public class ParseModelService : IParseModelService
    {
        public List<PropertyModel> Parse(List<string> InputList)
        {
            var PropertyModels = new List<PropertyModel>();
            foreach (var Input in InputList)
            {
                if (Input == null) continue;
                var Words = Regex.Split(Input, @"\s+").Where(S => S != string.Empty).ToArray();
                for (var I = 0; I < Words.Length; I++)
                {
                    if (Words[I] != "public") continue;
                    if (Words[I + 1].Contains('(') || Words[I + 2].Equals("class"))
                    {
                        break;
                    }
                    if (Words[I + 1].Contains("virtual") || (
                      !Words[I + 1].Contains("int") &&
                      !Words[I + 1].Contains("string") &&
                      !Words[I + 1].Contains("TimeSpan") &&
                       !Words[I + 1].Contains("bool") &&
                       !Words[I + 1].Contains("double") &&
                       !Words[I + 1].Contains("float") &&
                      !Words[I + 1].Contains("DateTime")))
                    {
                        PropertyModels.Add(new PropertyModel { Name = Words[I + 2], Type = Words[I + 1], IsVirtual = true });
                    }
                    else
                    {
                        PropertyModels.Add(new PropertyModel { Name = Words[I + 2], Type = Words[I + 1], IsVirtual = false });
                    }

                }
            }
            return PropertyModels;
        }
    }
}