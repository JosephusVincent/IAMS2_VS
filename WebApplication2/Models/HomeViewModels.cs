using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication2.Models
{
    public class HomeViewModels
    {
        public class MyData{
           public string PhoneNumber { get; set; }
        }

        public class whData {
            public DataTable dt { get; set; }
        }
        public class MovieDBContext : DbContext
        {
            public DbSet<MovieDBContext> Movies { get; set; }
        }
    }
}