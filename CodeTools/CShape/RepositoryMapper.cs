using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTools.Util;
namespace CodeTools.CShape
{
    public class RepositoryMapper
    {
        private static string template = Util.IOHelper.FileRead(String.Format("{0}\\Template\\{1}", System.Environment.CurrentDirectory, "CRepositoryMapper.tml"));
        public static String Genrate(String tabName, String dbConfig, String dbStr, DBType dbType)
        {
            string className = ConvertHelper.TableNameToClassName(tabName);
            StringBuilder column = new StringBuilder();
            StringBuilder param = new StringBuilder();
            StringBuilder clmparam = new StringBuilder();
            StringBuilder clazzclm = new StringBuilder();

            String result = template.Replace("$dbconfig$", dbConfig).Replace("$classname$", className).Replace("$tabname$", tabName);

            if (!string.IsNullOrEmpty(dbStr))
            {
                List<String> flist = new List<String>();
                if (dbType == DBType.MySql)
                {
                    flist = MySqlHelper.GetFields(dbStr, tabName);
                }
                if (dbType == DBType.SqlService)
                {
                    flist = SqlServiceHelper.GetFields(dbStr, tabName);
                }
                if (flist.Count > 0)
                {
                    foreach (var o in flist)
                    {
                        if (!o.ToLower().Equals("id"))
                        {
                            string paramStr = ConvertHelper.TableNameToClassName(o);
                            column.Append(o + ",");
                            
                            param.Append("@" + paramStr + ",");
                            if (!o.ToLower().Contains("create"))
                            {
                                clmparam.Append(o + "=@" + paramStr + ",");
                            }                           
                            
                            clazzclm.Append(o + " as " + paramStr + ",");  
                                                     
                        }
                    }
                }
                result = result.Replace("$column=param$", clmparam.ToString().Trim(',')).
                    Replace("$param$", param.ToString().Trim(',')).
                    Replace("$column$", column.ToString().Trim(',')).
                    Replace("$clazzclm$", clazzclm.ToString().Trim(','));
            }
            return result;

        }

       
    }
}
