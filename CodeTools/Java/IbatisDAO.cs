using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTools.Java
{
    public class IbatisDAO
    {
        private static string template = Util.IOHelper.FileRead(String.Format("{0}\\Template\\{1}", System.Environment.CurrentDirectory, "JIbatisDAO.tml"));
        public static String Genrate(String package, String className)
        {           
            return template.Replace("$package$", package).Replace("$classname$", className).Replace("$function$", "");

        }

        public static String TableGenrate(String package, String className)
        {
            String result = template.Replace("$package$", package).Replace("$classname$", className);
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("   public List<{0}> findAdminAll(Map<String, Object> params);\r\n\r\n", className));
            sb.Append("   public Integer findAdminAllCount(Map<String, Object> params);\r\n\r\n");
            return result.Replace("$function$", sb.ToString());
        }


    }
}
