using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;



namespace CodeTools.Util
{
    public class SqlServiceHelper
    {
      public static List<string> GetTables(string connStr,string dbName)
      {
          List<string> tabList = new List<string>();
          try
          {
              using (SqlConnection connection = new SqlConnection(connStr))
              {
                  string queryStr = String.Format("select name  from  {0}..sysobjects  where   xtype = 'U' order by  name", dbName);
                  SqlCommand command = new SqlCommand(queryStr, connection);
                  connection.Open();
                  SqlDataReader dr = command.ExecuteReader();
                  while (dr.Read())
                  {
                      string tabName = dr[0].ToString();
                      if (!String.IsNullOrEmpty(tabName))
                      {
                          tabList.Add(tabName);
                      }
                  }
                  dr.Close();
              }
          }
          catch { }
          return tabList;
        }

      public static List<string> GetFields(string connStr, string tabName)
      {
          List<string> fieldsList = new List<string>();

          try
          {
              using (SqlConnection connection = new SqlConnection(connStr))
              {
                  string queryStr = String.Format("select name,Type_name(xusertype),isnullable  from  syscolumns where  id = Object_id('{0}')", tabName);
                  SqlCommand command = new SqlCommand(queryStr, connection);
                  connection.Open();
                  SqlDataReader dr = command.ExecuteReader();
                  while (dr.Read())
                  {
                      string fName = dr[0].ToString();
                      if (!String.IsNullOrEmpty(fName))
                      {
                          fieldsList.Add(fName);
                      }                      
                  }
                  dr.Close();
              }
          }
          catch { }

          return fieldsList;
      }

      public static List<FieldProperty> GetProperties(string connStr, string tabName)
      {
          List<FieldProperty> list = new List<FieldProperty>();
          try
          {
              using (SqlConnection connection = new SqlConnection(connStr))
              {
                  string queryStr = String.Format("select name,Type_name(xusertype) as typename,isnullable  from  syscolumns where id = Object_id('{0}')", tabName);
                  SqlCommand command = new SqlCommand(queryStr, connection);
                  connection.Open();
                  SqlDataReader dr = command.ExecuteReader();
                  while (dr.Read())
                  {
                      string cName = dr[0].ToString();
                      string cType = dr[1].ToString();
                      string cNull = dr[2].ToString().Equals("0") ? "yes" : "no";

                      if (!String.IsNullOrEmpty(cName) && !String.IsNullOrEmpty(cType))
                      {
                          list.Add(new FieldProperty() { FildName = cName, TypeName = cType, IsNull = cNull });
                      }

                  }
                  dr.Close();
              }
          }
          catch { }
          return list;
      }

      public static string GetDBName(string connStr )
      {
          //Server=101.200.77.7;Database=nData;User Id=sa;password=123qwe!@#QWE;
          string result = "";
          String[] arryConn = connStr.Split(';');
          foreach(var o in arryConn){
              if (o.ToLower().Contains("database=")){
                  result=o.Split('=').ToList().LastOrDefault();
                  break;
              }
          }
          return result;
      }
    }
}
