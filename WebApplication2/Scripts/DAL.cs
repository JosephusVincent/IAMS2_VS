using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication2.Scripts
{
    public class DAL
    {
        public void Retrieve()
        {
            DataTable dt = new DataTable();
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStrings"].ConnectionString);
            string queryString = "SELECT * FROM tWareHouse";
            using (Conn)
            {
                var command = new SqlCommand(queryString, Conn);
                Conn.Open();
                using (var reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                    //while (reader.Read())
                    //{
                    //    temp = reader[0];
                    //}
                    //dt.fill
                }
            }
        }
    }
}