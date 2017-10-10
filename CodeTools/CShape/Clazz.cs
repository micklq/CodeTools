using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTools.Util;
namespace CodeTools.CShape
{
   public class Clazz
    {
       private static string template = Util.IOHelper.FileRead(String.Format("{0}\\Template\\{1}", System.Environment.CurrentDirectory, "CClazz.tml"));

       public static String Genrate(String nameSpace, String tabName, String dbConn, DBType dbType)
        {
            string className = ConvertHelper.TableNameToClassName(tabName);
            String result = template.Replace("$namespace$", nameSpace).Replace("$classname$", className);
            //添加properties
            StringBuilder sb = new StringBuilder();

            List<FieldProperty> flist = new List<FieldProperty>();
            if (dbType == DBType.MySql) {

                flist = MySqlHelper.GetProperties(dbConn, tabName);
            }
            if (dbType == DBType.SqlService)
            {
                flist = SqlServiceHelper.GetProperties(dbConn, tabName);
            }
            
            if (flist.Count > 0)
            {
                foreach (var o in flist)
                {
                    if (!o.FildName.ToLower().Equals("id"))
                    {
                      
                        o.FildName = ConvertHelper.TableNameToClassName(o.FildName);
                      
                        if (dbType == DBType.MySql)
                        {
                            sb.Append("        public " + ConvertHelper.MySqlTypeToCShpaeType(o) + " " + o.FildName + " { get; set; } \r\n");
                        }
                        if (dbType == DBType.SqlService)
                        {
                            sb.Append("        public " + ConvertHelper.SqlServiceTypeToCShpaeType(o) + " " + o.FildName + " { get; set; } \r\n");
                            
                        }
                    }
                }
            }
            return result.Replace("$properties$", sb.ToString());
        }
    }
}
