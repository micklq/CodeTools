using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTools.Util;

namespace CodeTools.Java
{
    public class JavaGenrate
    {

        private static string desktopDir = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), DateTime.Now.ToString("yyyyMMdd"));
        public static string Service(string package, string className, bool createdDir)
        {
            IOHelper.DirCreate(desktopDir);

            var jStr = CodeTools.Java.Service.Genrate(package, className);
            var fileName = String.Format("{0}\\{1}Service.java", desktopDir, className);
            if (createdDir)
            {
                string packageDir = package.Replace(".","\\");
                fileName = String.Format("{0}\\{1}\\service\\{2}Service.java", desktopDir, packageDir, className);
            }

            IOHelper.FileCreate(fileName, jStr);

            return jStr;
        }

        public static string ServiceByTable(string package, string className, bool createdDir)
        {
            IOHelper.DirCreate(desktopDir);

            var jStr = CodeTools.Java.Service.TableGenrate(package, className);
            var fileName = String.Format("{0}\\{1}Service.java", desktopDir, className);
            if (createdDir)
            {
                string packageDir = package.Replace(".", "\\");
                fileName = String.Format("{0}\\{1}\\service\\{2}Service.java", desktopDir, packageDir, className);
            }

            IOHelper.FileCreate(fileName, jStr);

            return jStr;
        }


        public static String ServiceImpl(string package, string className, bool createdDir)
        {
            IOHelper.DirCreate(desktopDir);

            var jStr = CodeTools.Java.ServiceImpl.Genrate(package, className);
            var fileName = String.Format("{0}\\{1}ServiceImpl.java", desktopDir, className);
            if (createdDir)
            {
                string packageDir = package.Replace(".", "\\");
                fileName = String.Format("{0}\\{1}\\service\\impl\\{2}ServiceImpl.java", desktopDir, packageDir, className);
            }
            IOHelper.FileCreate(fileName, jStr);

            return jStr;
        }
        public static String ServiceImplByTable(string package, string className, bool createdDir)
        {
            IOHelper.DirCreate(desktopDir);

            var jStr = CodeTools.Java.ServiceImpl.TableGenrate(package, className);
            var fileName = String.Format("{0}\\{1}ServiceImpl.java", desktopDir, className);
            if (createdDir)
            {
                string packageDir = package.Replace(".", "\\");
                fileName = String.Format("{0}\\{1}\\service\\impl\\{2}ServiceImpl.java", desktopDir, packageDir, className);
            }
            IOHelper.FileCreate(fileName, jStr);

            return jStr;
        }

        public static String IbatisDAO(string package, string className, bool createdDir)
        {
            var jStr = CodeTools.Java.IbatisDAO.Genrate(package, className);
            var fileName = String.Format("{0}\\{1}DAO.java", desktopDir, className);
            if (createdDir)
            {
                string packageDir = package.Replace(".", "\\");
                fileName = String.Format("{0}\\{1}\\data\\mapper\\{2}DAO.java", desktopDir, packageDir, className);
            }
            IOHelper.FileCreate(fileName, jStr);
            return jStr;
        }

        public static string IbatisDAOByTable(string package, string className, bool createdDir)
        {
            string jStr = CodeTools.Java.IbatisDAO.TableGenrate(package, className);
            string fileName = String.Format("{0}\\{1}DAO.java", desktopDir, className);
            if (createdDir)
            {
                string packageDir = package.Replace(".", "\\");
                fileName = String.Format("{0}\\{1}\\data\\mapper\\{2}DAO.java", desktopDir, packageDir, className);
            }
            IOHelper.FileCreate(fileName, jStr);
            return jStr;
        }

        public static String IbatisMapper(string package, string className, bool createdDir)
        {
            var jStr = CodeTools.Java.IbatisMapper.Genrate(package, className);
            String clazzName = String.Format("{0}{1}", className.Substring(0, 1).ToLower(), className.Substring(1));
            var fileName = String.Format("{0}\\{1}Mapper.xml", desktopDir, clazzName);
            if (createdDir)
            {
                string packageDir = package.Replace(".", "\\");
                fileName = String.Format("{0}\\{1}\\data\\mapper\\{2}Mapper.xml", desktopDir, packageDir, clazzName);
            }

            IOHelper.FileCreate(fileName, jStr);
            return jStr;
        }

        public static String IbatisMapperByTable(string package, string className, string dbStr, bool createdDir)
        {
            var jStr = CodeTools.Java.IbatisMapper.TableGenrate(package, className, dbStr);
            String clazzName = String.Format("{0}{1}", className.Substring(0, 1).ToLower(), className.Substring(1));
            var fileName = String.Format("{0}\\{1}Mapper.xml", desktopDir, clazzName);
            if (createdDir)
            {
                string packageDir = package.Replace(".", "\\");
                fileName = String.Format("{0}\\{1}\\data\\mapper\\{2}Mapper.xml", desktopDir, packageDir, clazzName);
            }

            IOHelper.FileCreate(fileName, jStr);
            return jStr;
        }

        public static String Repository(string package, string className, bool createdDir)
        {
            var jStr = CodeTools.Java.Repository.Genrate(package, className);
            var fileName = String.Format("{0}\\{1}Repository.java", desktopDir, className);
            if (createdDir)
            {
                string packageDir = package.Replace(".", "\\");
                fileName = String.Format("{0}\\{1}\\data\\repository\\{2}Repository.java", desktopDir, packageDir, className);
            }

            IOHelper.FileCreate(fileName, jStr);
            return jStr;
        }

    }
}
