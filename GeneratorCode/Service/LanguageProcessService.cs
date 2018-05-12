
using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;

namespace GeneratorCode.Service
{
    public class LanguageProcessService
    {
        public static string ToPlural(string Single)
        {
            if (Single.EndsWith("bo")) return Single + "s";
            return PluralizationService.CreateService(CultureInfo.GetCultureInfo("en-us")).Pluralize(Single);
        }

        public static string ToSingle(string Plural)
        {
            return PluralizationService.CreateService(CultureInfo.GetCultureInfo("en-us")).Singularize(Plural);
        }
    }
}