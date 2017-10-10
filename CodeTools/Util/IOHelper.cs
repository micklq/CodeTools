using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeTools.Util
{
    public class IOHelper
    {
      public static void  DirCreate(string dir)
      {          
             if (!Directory.Exists(dir))
              {
                  Directory.CreateDirectory(dir);
              }
        }
      public static string FileRead(string fileName)
      {
          StringBuilder result = new StringBuilder(); 
          if (File.Exists(fileName)) {
              StreamReader sr = new StreamReader(fileName, Encoding.UTF8);
              string line="";
              while ((line = sr.ReadLine()) != null)
              {                  
                  result.Append(line.ToString()+"\r\n");
              }
          }
          return result.ToString();
          

      }
      public static void FileCreate(string fileName, string contents)
      {
          string dir = fileName.Substring(0, fileName.LastIndexOf("\\"));
          if (!Directory.Exists(dir))
          {
              Directory.CreateDirectory(dir);
          }          
          FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite); //可以指定盘符，也可以指定任意文件名
          StreamWriter sw = new StreamWriter(fs); // 创建写入流
          sw.WriteLine(contents); // 写入内容
          sw.Close(); //关闭文件

      }

    }
}
