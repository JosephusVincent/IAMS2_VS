using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            DataTable dt = new DataTable();
            DAL Access = new DAL();
            ViewBag.WH = Access.Retrieve();

            ////dt.DataSet.Access.Retrieve();
            //Console.WriteLine(Access.Retrieve());
            //IEnumerable<DataRow> sequence = Access.Retrieve()..ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}