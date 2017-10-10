using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTools.Java
{
    public class ServiceImpl
    {
        private static string template = Util.IOHelper.FileRead(String.Format("{0}\\Template\\{1}", System.Environment.CurrentDirectory, "JServiceImpl.tml"));
        public static String Genrate(String package, String className)
        {
            String clazzName = String.Format("{0}{1}", className.Substring(0, 1).ToLower(), className.Substring(1));

            return template.Replace("$package$", package).Replace("$classname$", className).Replace("$clazzname$", clazzName).Replace("$function$", "");

        }

        public static String TableGenrate(String package, String className)
        {
            String clazzName = String.Format("{0}{1}", className.Substring(0, 1).ToLower(), className.Substring(1));
            String result = template.Replace("$package$", package).Replace("$classname$", className).Replace("$clazzname$", clazzName);
            //添加接口
            StringBuilder sb = new StringBuilder();
            sb.Append("	@Override\r\n");
            sb.Append(String.Format("	public Page<{0}> findAdminAll(int page, int size, Map<String, Object> params) ", className));
            sb.Append("{ \r\n");
            sb.Append(String.Format("		Integer count = {0}DAO.findAdminAllCount(params);\r\n", clazzName));
            sb.Append(String.Format("		List<{0}> list = new ArrayList<{0}>();\r\n", className));
            sb.Append("			if (count > 0) {\r\n");
            sb.Append("			int pageStart = (page - 1) * size;\r\n");
            sb.Append("			params.put(\"pageStart\", pageStart);\r\n");
            sb.Append("			params.put(\"pageSize\", size);\r\n");
            sb.Append(String.Format("			list = {0}DAO.findAdminAll(params);\r\n", clazzName));
            sb.Append("		}\r\n");
            sb.Append(String.Format("		Page<{0}> plist = new PageImpl<{0}>(list, new PageRequest(page - 1, size, null), count);\r\n", className));
            sb.Append("		return plist;\r\n");
            sb.Append("	}\r\n");
            return result.Replace("$function$", sb.ToString());

        }
    }
}
