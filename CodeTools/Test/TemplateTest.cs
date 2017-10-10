using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeTools.Tests
{
    public class TemplateTest : TestBase
    {

        [Test]
        public void ReadTemplateTest()
        {
            String sysPath = System.Environment.CurrentDirectory;
            Console.WriteLine(sysPath);
            string path = sysPath + "\\Template\\JIbatisMapper.tml";
            Console.WriteLine(path);
            String r=Util.IOHelper.FileRead(path);
            Console.WriteLine(r);
            r = r.Replace("$package$", "com.mick.apps");
            Console.WriteLine(r);

        }


        [Test]
        public void StringSubTest()
        {
            String className = "AppVersoin";
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("public class {0}ServiceImpl extends BaseServiceImpl<{0}, Long> implements {0}Service ", className));
            sb.Append("{\r\n");
            Console.WriteLine(sb.ToString());        
            String clazzName = String.Format("{0}{1}", className.Substring(0, 1).ToLower(), className.Substring(1));
            Console.WriteLine(clazzName);          
        }

       

        [Test]
        public void LettersUpperTest()
        {
            StringBuilder sb = new StringBuilder();
            String className = "AbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYZz";
            foreach (var o in className.ToCharArray()) 
            {
                if (o >= 65 && o <= 90)
                {
                    Console.Write(o.ToString().ToLower());
                    sb.Append(String.Format("_{0}", o.ToString().ToLower()));
                }
                else
                {
                    Console.Write(o);
                    sb.Append(o.ToString());
                }               

            }
            Console.WriteLine("\r\n");
            Console.WriteLine(sb.ToString().Trim('_'));
            
           
        }

        [Test]
        public void UnderlineLettersTest()
        {
            StringBuilder sb = new StringBuilder();
            String className = "AbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYZz";

            Console.WriteLine(CodeTools.Util.ConvertHelper.LetterToUnderline(className));
            String tabName = "abc_dd";
            Console.WriteLine(CodeTools.Util.ConvertHelper.UnderlineToInitialsUpper(tabName));

        }
    }
}
