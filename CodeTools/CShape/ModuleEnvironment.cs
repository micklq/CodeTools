using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTools.CShape
{
    public class ModuleEnvironment
    {       
        private static string template = Util.IOHelper.FileRead(String.Format("{0}\\Template\\{1}", System.Environment.CurrentDirectory, "CModuleEnvironment.tml"));
        public static String Genrate(String nameSpace, String moduleName)
        {
            return template.Replace("$namespace$", nameSpace).Replace("$modulename$", moduleName);

        }
    }
}
