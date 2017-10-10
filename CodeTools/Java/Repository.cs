using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTools.Java
{
   public class Repository
    {
       private static string template = Util.IOHelper.FileRead(String.Format("{0}\\Template\\{1}", System.Environment.CurrentDirectory, "JRepository.tml"));

       public static String Genrate(String package, String className)
       {           
           String clazzName = String.Format("{0}{1}", className.Substring(0, 1).ToLower(), className.Substring(1));
           return template.Replace("$package$", package).Replace("$classname$", className).Replace("$clazzname$", clazzName);
       }
    }
}
