using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication2
{
    public class DAL
    {
        public string Retrieve()
        {
            DataTable dt = new DataTable();
            string retString = "";
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MovieDBContext"].ConnectionString);
            string queryString = "SELECT TOP 1 Name FROM tWareHouse";
            using (Conn)
            {
                var command = new SqlCommand(queryString, Conn);
                Conn.Open();
                using (var reader = command.ExecuteReader())
                {
                    //retString = reader[0].ToString();
                    while (reader.Read())
                    {
                        retString = reader[0].ToString();
                    }
                    //dt.fill
                }
            }
            //System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            //List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            //Dictionary<string, object> row;
            //foreach (DataRow dr in dt.Rows)
            //{
            //    row = new Dictionary<string, object>();
            //    foreach (DataColumn col in dt.Columns)
            //    {
            //        row.Add(col.ColumnName, dr[col]);
            //    }
            //    rows.Add(row);
            //}
            //return serializer.Serialize(rows);
            return retString;
        }
    }
}