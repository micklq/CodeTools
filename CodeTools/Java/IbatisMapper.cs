using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTools.Util;
namespace CodeTools.Java
{
    public class IbatisMapper
    {
        private static string template = Util.IOHelper.FileRead(String.Format("{0}\\Template\\{1}", System.Environment.CurrentDirectory, "JIbatisMapper.tml"));

        public static String Genrate(String package, String className)
        {
            return template.Replace("$package$", package).Replace("$classname$", className).Replace("$sqlselect$", "");
        }

        public static String TableGenrate(String package, String className, String dbConn)
        {
            String result = template.Replace("$package$", package).Replace("$classname$", className);
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrEmpty(dbConn))
            {
                string tabName = ConvertHelper.LetterToUnderline(className);            
                sb.Append("	<select id=\"findAdminAllCount\" parameterType=\"map\" resultType=\"Integer\">\r\n");
                sb.Append("		select count(o.id) \r\n");
                sb.Append(String.Format("		from {0} o \r\n", tabName));
                sb.Append("	</select>\r\n");
                sb.Append(String.Format("	<select id=\"findAdminAll\" parameterType=\"map\" resultType=\"{0}.data.entity.{1}\">\r\n", package, className));
                sb.Append("		select \r\n");
                sb.Append("			o.id \r\n"); //公有字段
                sb.Append("			,o.create_at as createDate \r\n"); //公有字段
                sb.Append("			,o.modify_at as modifyDate \r\n\r\n"); //公有字段	
                //数据库表字段
                List<string> flist = MySqlHelper.GetFields(dbConn, tabName);
                if (flist.Count > 0)
                {
                    foreach (var o in flist)
                    {
                        if (!o.Contains("id") && !o.Contains("create_at") && !o.Contains("modify_at"))
                        {
                            sb.Append(String.Format("			,o.{0} as {1} \r\n", o, ConvertHelper.UnderlineToInitialsUpper(o)));
                        }
                    }
                }
                sb.Append(String.Format("		from {0} o \r\n", tabName));
                sb.Append("		order by o.id desc \r\n");
                sb.Append("		<include refid=\"page\"/> \r\n");
                sb.Append("	</select>\r\n\r\n");
            }
            sb.Append("");


            return result.Replace("$sqlselect$", sb.ToString());
        }
    }
}
