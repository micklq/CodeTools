using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MySql.Data.MySqlClient;

namespace CodeTools.Tests
{
    public class MySqlTest : TestBase
    {

        [Test]
        public void DBTypeTest()
        {
            Console.WriteLine(CodeTools.Util.DBType.MySql);
            Console.WriteLine((int)CodeTools.Util.DBType.MySql);
            Console.WriteLine(CodeTools.Util.DBType.SqlService);
            Console.WriteLine((int)CodeTools.Util.DBType.SqlService);
        }

        [Test]
        public void ShowPropertiesTest()
        {
            string dbStr = "Server=192.168.1.21;port=3306;user id=root;password=123456;database=rainbow;Charset=utf8";
            MySqlConnection conn = new MySqlConnection(dbStr);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "show tables";
            conn.Open();
            MySqlDataReader dr = command.ExecuteReader();
            Console.WriteLine("==============show tables==============");
            List<string> tabNameList = new List<string>();
            while (dr.Read())
            {
                string tabName = dr.GetString(0);
                tabNameList.Add(tabName);

            }
            dr.Close();

            if (tabNameList.Count > 0)
            {

                foreach (var o in tabNameList)
                {
                    Console.WriteLine("==============show tables files==============");
                    Console.WriteLine(o);

                    List<Util.FieldProperty> dic = Util.MySqlHelper.GetProperties(dbStr, o);
                    foreach (var dd in dic) {

                        Console.WriteLine(dd.FildName +"==>>"+dd.TypeName+ "\r\n");
                    } 
                }
            }

            conn.Close();


        }

        [Test]
        public void ShowTablesTest()
        {
            string dbStr = "Server=192.168.1.21;port=3306;user id=root;password=123456;database=rainbow;Charset=utf8";
            MySqlConnection conn = new MySqlConnection(dbStr);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "show tables";
            conn.Open();
            MySqlDataReader dr = command.ExecuteReader();
            Console.WriteLine("==============show tables==============");
            List<string> tabNameList = new List<string>();
            while (dr.Read())
            {
               string tabName = dr.GetString(0);
               tabNameList.Add(tabName);              

            }
            dr.Close();

            if (tabNameList.Count > 0) {

                foreach (var o in tabNameList) {
                    Console.WriteLine("==============show tables files==============");
                    Console.WriteLine(o); 
                    command.CommandText = "show fields from " + o;
                    MySqlDataReader drf = command.ExecuteReader();
                    while (drf.Read())
                    {
                        string fName = drf.GetString(0);
                        string fType = drf.GetString(1);
                        Console.Write(fName + ":" + fType +"  ");                        
                    }
                    Console.WriteLine("\r\n");
                    drf.Close();
                }
            }

          conn.Close();             
            
              
        }

        
    }
}
