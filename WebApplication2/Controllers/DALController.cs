using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication2.Controllers
{
    public class DALController : Controller
    {
        // GET: DAL
        public ActionResult Index()
        {
            return View();
        }

        public void Access() {
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStrings"].ConnectionString);
            string queryString = "SELECT * FROM tWareHouse";
            using (Conn)
            {
                var command = new SqlCommand(queryString, Conn);
                Conn.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
                        ViewBag.ASD = reader[0];
                    }
                }
            }
        }
    }
}