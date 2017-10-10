using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace CodeTools.Util
{
    public class MySqlHelper
    {
      public static List<string> GetTables(string connStr)
      {
          List<string> tabList = new List<string>();
          try 
          {
              MySqlConnection conn = new MySqlConnection(connStr);
              MySqlCommand command = conn.CreateCommand();
              command.CommandText = "show tables";
              conn.Open();
              MySqlDataReader dr = command.ExecuteReader();
              while (dr.Read())
              {
                  string tabName = dr.GetString(0);
                  if (!String.IsNullOrEmpty(tabName))
                  {
                      tabList.Add(tabName);
                  }
              }
              dr.Close();
              command.Dispose();
              conn.Close(); 
          }
          catch { }
          
          return tabList;
        }

      public static List<string> GetFields(string connStr, string tabName)
      {
          List<string> fieldsList = new List<string>();
          try
          {
              MySqlConnection conn = new MySqlConnection(connStr);
              MySqlCommand command = conn.CreateCommand();
              command.CommandText = "show fields from " + tabName;
              conn.Open();
              MySqlDataReader dr = command.ExecuteReader();
              while (dr.Read())
              {
                  string fName = dr.GetString(0);
                  if (!String.IsNullOrEmpty(fName))
                  {
                      fieldsList.Add(fName);
                  }
              }
              dr.Close();
              command.Dispose();
              conn.Close();
          }
          catch { }

          return fieldsList;
      }

      public static List<FieldProperty> GetProperties(string connStr, string tabName)
      {
          List<FieldProperty> list = new List<FieldProperty>();
          try
          {

              MySqlConnection conn = new MySqlConnection(connStr);
              MySqlCommand command = conn.CreateCommand();
              command.CommandText = "show fields from " + tabName;
              conn.Open();
              MySqlDataReader dr = command.ExecuteReader();
              while (dr.Read())
              {
                  string cName = dr.GetString(0);
                  string cType = dr.GetString(1);
                  string cNull = dr.GetString(1);
                  if (!String.IsNullOrEmpty(cName) && !String.IsNullOrEmpty(cType))
                  {
                      list.Add(new FieldProperty() { FildName = cName, TypeName = cType, IsNull = cNull });
                  }
              }
              dr.Close();
              command.Dispose();
              conn.Close();
          }
          catch { }
          return list;
      }
    }
}
