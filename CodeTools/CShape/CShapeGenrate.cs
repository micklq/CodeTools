using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTools.Util;

namespace CodeTools.CShape
{
    public class CShapeGenrate
    {

        private static string desktopDir = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), DateTime.Now.ToString("yyyyMMdd"));
        public static string Clazz(String nameSpace, String tabName, String dbConn, DBType dbType)
        {
            IOHelper.DirCreate(desktopDir);
            string className = ConvertHelper.TableNameToClassName(tabName);
            var cStr = CodeTools.CShape.Clazz.Genrate(nameSpace, tabName, dbConn, dbType);
            var fileName = String.Format("{0}\\{1}\\{2}.cs", desktopDir, nameSpace, className);         

            IOHelper.FileCreate(fileName, cStr);

            return cStr;
        }

        public static string ModuleEnvironment(String nameSpace)
        {
            IOHelper.DirCreate(desktopDir);
            String moduleName = nameSpace.Split('.').ToList().LastOrDefault();
            var cStr = CodeTools.CShape.ModuleEnvironment.Genrate(nameSpace, moduleName);
            var fileName = String.Format("{0}\\{1}\\ModuleEnvironment.cs", desktopDir, nameSpace); 

            IOHelper.FileCreate(fileName, cStr);

            return cStr;
        }


        public static String IRepository(String nameSpace, String className)
        {
            IOHelper.DirCreate(desktopDir);

            var cStr = CodeTools.CShape.IRepository.Genrate(nameSpace, className);
            var fileName = String.Format("{0}\\{1}\\DataRepositories\\I{2}Repository.cs", desktopDir, nameSpace, className);
            
            IOHelper.FileCreate(fileName, cStr);

            return cStr;
        }
        public static String Repository(String nameSpace, String className)
        {
            IOHelper.DirCreate(desktopDir);
            var cStr = CodeTools.CShape.Repository.Genrate(nameSpace, className);
            var fileName = String.Format("{0}\\{1}.DataRepositories\\{2}Repository.cs", desktopDir, nameSpace, className);         
            IOHelper.FileCreate(fileName, cStr);

            return cStr;
        }


        public static String RepositoryMapper(String nameSpace, String tabName, String dbConfig, String dbStr, DBType dbType)
        {
            var cStr = CodeTools.CShape.RepositoryMapper.Genrate(tabName, dbConfig, dbStr, dbType);            
            String moduleName = nameSpace.Split('.').ToList().LastOrDefault();
            string className = ConvertHelper.TableNameToClassName(tabName);
            var fileName = String.Format("{0}\\{1}.DataRepositories\\sqlmap\\{2}\\{3}Repository.sql.xml", desktopDir, nameSpace, moduleName, className);     
            
            IOHelper.FileCreate(fileName, cStr);
            return cStr;
        }

    }
}
