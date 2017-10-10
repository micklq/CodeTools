using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeTools.Util
{
    public class ConvertHelper
    {

        /// <summary>
        /// 大写字母转小写并添加下划线前缀
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static String LetterToUnderline(String str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var o in str.ToCharArray())
            {
                if (o >= 65 && o <= 90)
                {
                    sb.Append(String.Format("_{0}", o.ToString().ToLower()));
                }
                else
                {
                    sb.Append(o.ToString());
                }
            }
            return sb.ToString().Trim('_');
        }

        /// <summary>
        /// 下划线转首字母大写
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static String UnderlineToInitialsUpper(String str)
        {
            StringBuilder sb = new StringBuilder();
            string[] aryStr = str.Split('_');
            for (var i = 0; i < aryStr.Length; i++)
            {
                if (i != 0)
                {
                    if (aryStr[i].ToCharArray().Length > 1)
                    {
                        string combinStr = aryStr[i].Substring(0, 1).ToUpper() + aryStr[i].Substring(1);
                        sb.Append(combinStr);
                    }
                    else 
                    {
                        sb.Append(aryStr[i].ToLower());
                    } 
                }
                else 
                {
                    sb.Append(aryStr[i]);
                } 
            }
            return sb.ToString();
        }
        public static String TableNameToClassName(String str)
        {

            string _clazzName =  UnderlineToInitialsUpper(str);
            string clazzName = _clazzName.Substring(0, 1).ToUpper() + _clazzName.Substring(1);
            return clazzName;
            
                      
        }

        public static String MySqlTypeToCShpaeType(FieldProperty types)
        {
            string result="";
            if (types.TypeName.ToLower().Contains("bit"))
            {
                if (types.TypeName.ToLower().Contains("no")) { result = "bool"; }
                else {  result = "bool?";  }
                return result;
            }
            if (types.TypeName.ToLower().Contains("bigint"))
            {
                if (types.TypeName.ToLower().Contains("no")) { result = "long"; }
                else { result = "long?"; }
                return result;
            }
            if (types.TypeName.ToLower().Contains("int"))
            {
                if (types.TypeName.ToLower().Contains("no")) { result = "int"; }
                else { result = "int?"; }
                return result;
            }
            if (types.TypeName.ToLower().Contains("double"))
            {               
                if (types.TypeName.ToLower().Contains("no")) { result = "double"; }
                else { result = "double?"; }
                return result;
            }

            if (types.TypeName.ToLower().Contains("float"))
            {
                if (types.TypeName.ToLower().Contains("no")) { result = "float"; }
                else { result = "float?"; }
                return result;
            }           
           
            if (types.TypeName.ToLower().Contains("decimal"))
            {
                if (types.TypeName.ToLower().Contains("no")) { result = "decimal"; }
                else { result = "decimal?"; }
                return result;
            }
            if (types.TypeName.ToLower().Contains("varchar") || types.TypeName.ToLower().Contains("text"))
            {
                result = "string";
                return result;
            }
            if (types.TypeName.ToLower().Contains("char"))
            {
                if (types.TypeName.ToLower().Contains("no")) { result = "char"; }
                else { result = "char?"; }
                return result;
            }
            if (types.TypeName.ToLower().Contains("datetime"))
            {                
                if (types.TypeName.ToLower().Contains("no")) { result = "DateTime"; }
                else { result = "DateTime?"; }
                return result;
            }
            if (types.TypeName.ToLower().Contains("timestamp"))
            {
                if (types.TypeName.ToLower().Contains("no")) { result = "long"; }
                else { result = "long?"; }
                return result;
            }

            return result;


        }

        public static String SqlServiceTypeToCShpaeType(FieldProperty types)
        {
            string result = "";
            if (types.TypeName.ToLower().Contains("bigint"))
            {
                if (types.TypeName.ToLower().Contains("no")) { result = "long"; }
                else { result = "long?"; }
                return result;
            }
            if (types.TypeName.ToLower().Contains("binary") || types.TypeName.ToLower().Contains("sql_variant"))
            {
                result = "object";               
                return result;
            }
            if (types.TypeName.ToLower().Contains("bit"))
            {
                if (types.TypeName.ToLower().Contains("no")) { result = "bool"; }
                else { result = "bool?"; }
                return result;
            }
            if (types.TypeName.ToLower().Contains("datetime"))
            {
                if (types.TypeName.ToLower().Contains("no")) { result = "DateTime"; }
                else { result = "DateTime?"; }
                return result;
            }
            if (types.TypeName.ToLower().Contains("decimal") ||
                types.TypeName.ToLower().Contains("money") ||
                types.TypeName.ToLower().Contains("smallmoney") ||
                types.TypeName.ToLower().Contains("numeric"))
            {
                if (types.TypeName.ToLower().Contains("no")) { result = "decimal"; }
                else { result = "decimal?"; }
                return result;
            }

            if (types.TypeName.ToLower().Contains("float"))
            {
                if (types.TypeName.ToLower().Contains("no")) { result = "double"; }
                else { result = "double?"; }
                return result;
            }
            if (types.TypeName.ToLower().Contains("real"))
            {
                if (types.TypeName.ToLower().Contains("no")) { result = "float"; }
                else { result = "float?"; }
                return result;
            }
            if (types.TypeName.ToLower().Contains("image"))
            {              
                result = "byte[]";
                return result;
            } 
            if (types.TypeName.ToLower().Contains("int"))
            {
                if (types.TypeName.ToLower().Contains("no")) { result = "int"; }
                else { result = "int?"; }
                return result;
            }
            if (types.TypeName.ToLower().Contains("uniqueidentifier"))
            {
                if (types.TypeName.ToLower().Contains("no")) { result = "Guid"; }
                else { result = "Guid?"; }
                return result;
            }

            if (types.TypeName.ToLower().Contains("char") ||
                types.TypeName.ToLower().Contains("nchar") ||
                types.TypeName.ToLower().Contains("ntext") || 
                types.TypeName.ToLower().Contains("text") || 
                types.TypeName.ToLower().Contains("varchar") ||
                types.TypeName.ToLower().Contains("nvarchar") ||               
                types.TypeName.ToLower().Contains("xml"))
            {
                result = "string";
                return result;
            }  

            return result;


        }

    }
}
