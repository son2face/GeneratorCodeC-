using System.Collections.Generic;
using System.Linq;

namespace GeneratorCode.Service
{
    public class Generation
    {
        public Dictionary<string, string> Dictionary = new Dictionary<string, string>();
        public Dictionary<string, string> Primitivepropertities = new Dictionary<string, string>();
        public Dictionary<string, string> Objectpropertities = new Dictionary<string, string>();
        public Dictionary<string, string> Arraypropertities = new Dictionary<string, string>();
        public List<string> Template;

        public void ReadFile()
        {
            Template = System.IO.File.ReadAllLines("").ToList();
        }

        public void WriteFile(string Path, string Result)
        {
            System.IO.File.WriteAllText(Path, Result);
        }

        public string Replace(string Input)
        {
            return Dictionary.Aggregate(Input, (Current, Pair) => Current.Replace(Pair.Key, Pair.Value));
        }

        public Generation()
        {
        }

        public Generation(List<string> Template)
        {
            this.Template = Template;
        }

        public string Analysis()
        {
            var Result = "";
            var i = 0;
            while (i < Template.Count)
            {
                var Line = Template[i].Trim();
                if (Line.Contains("[PRIMITIVEPROPERTIES]") || Line.Contains("[OBJECTPROPERTIES]") ||
                    Line.Contains("[ARRAYPROPERTIES]"))
                {
                    var Block = "";
                    var j = i + 1;
                    var Blocks = new List<string>();

                    #region Process create block and replace data

                    while (j < Template.Count && !Template[j].Contains("[END]"))
                    {
                        Block += Template[j] + "\n";
                        j++;
                    }
                    if (Line.Contains("[PRIMITIVEPROPERTIES]"))
                    {
                        foreach (var Pair in Primitivepropertities)
                        {
                            var Replace = Block.Replace("[ITEM.NAME]", Pair.Key);
                            Replace = Replace.Replace("[ITEM.TYPE]", Pair.Value);
                            Replace = Replace.Replace("[ITEM.TYPES]", LanguageProcessService.ToPlural(Pair.Value));
                            Blocks.Add(Replace);
                        }
                    }
                    else if (Line.Contains("[OBJECTPROPERTIES]"))
                    {
                        foreach (var Pair in Objectpropertities)
                        {
                            var Replace = Block.Replace("[ITEM.NAME]", Pair.Key);
                            Replace = Replace.Replace("[ITEM.TYPE]", Pair.Value);
                            Replace = Replace.Replace("[ITEM.TYPES]", LanguageProcessService.ToPlural(Pair.Value));
                            Blocks.Add(Replace);
                        }
                    }
                    else if (Line.Contains("[ARRAYPROPERTIES]"))
                    {
                        foreach (var Pair in Arraypropertities)
                        {
                            var Replace = Block.Replace("[ITEM.NAME]", Pair.Key);
                            Replace = Replace.Replace("[ITEM.TYPE]", Pair.Value);
                            Replace = Replace.Replace("[ITEM.TYPES]", LanguageProcessService.ToPlural(Pair.Value));
                            Blocks.Add(Replace);
                        }
                    }

                    #endregion

                    i = j;
                    Line = string.Join("\n", Blocks);
                }
                Result += Replace(Line) + "\n";
                i++;
            }
            return AnalysisConditional(Result);
        }

        public string AnalysisConditional(string Result)
        {
            var ifline = Result.Split('\n').ToList();
            var countif = 0;
            while (countif < ifline.Count)
            {
                if (ifline[countif].Contains("[IF]"))
                {
                    var conditional = true;
                    var conditions = ifline[countif].Trim().Split(' ').ToList();
                    for (int i = 2; i < conditions.Count - 1 && conditional; i+=4)
                    {
                        switch (conditions[i])
                        {
                            case "[EQ]":
                                conditional = conditions[i-1] == conditions[i+1];
                                break;
                            case "[NE]":
                                conditional = conditions[i - 1] != conditions[i + 1];
                                break;
                            case "[CT]":
                                conditional = conditions[i - 1].Contains(conditions[i + 1]);
                                break;
                            case "[NCT]":
                                conditional = !conditions[i - 1].Contains(conditions[i + 1]);
                                break;
                        }
                    }
                    if (conditional)
                    {
                        ifline[countif] = "";
                        int subBlockCount = countif + 1;
                        while (subBlockCount < ifline.Count && !ifline[subBlockCount].Contains("[ENDIF]"))
                        {
                            subBlockCount++;
                        }
                        ifline[subBlockCount] = "";
                        countif = subBlockCount;
                    }
                    else
                    {
                        ifline[countif] = "";
                        int subBlockCount = countif + 1;
                        while (subBlockCount < ifline.Count && !ifline[subBlockCount].Contains("[ENDIF]"))
                        {
                            ifline[subBlockCount] = "";
                            subBlockCount++;
                        }
                        ifline[subBlockCount] = "";
                        countif = subBlockCount;
                    }
                }
                countif++;
            }
            Result = string.Join("\n", ifline.Where(X => !X.Equals("")));
            return Result;
        }
    }
}