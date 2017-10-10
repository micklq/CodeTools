using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTools.Java
{
   public class Service
    {
       private static string template = Util.IOHelper.FileRead(String.Format("{0}\\Template\\{1}", System.Environment.CurrentDirectory, "JService.tml"));
       public static String Genrate(String package, String className)
       {
           return template.Replace("$package$", package).Replace("$classname$", className).Replace("$function$", "");

       }

       public static String TableGenrate(String package, String className)
       {
           String result = template.Replace("$package$", package).Replace("$classname$", className);
           //添加接口
           StringBuilder sb = new StringBuilder();
           sb.Append(String.Format("	public Page<{0}> findAdminAll(int page,int size,Map<String, Object> params);\r\n\r\n", className));
      
           return result.Replace("$function$", sb.ToString());
       }
    }
}
