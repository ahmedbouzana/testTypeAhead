//using MySql.Data.Entity;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using testTypeHead.Models;

namespace testTypeHead
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class WebAppContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        public WebAppContext()
            //Reference the name of your connection string ( WebAppCon )  
            : base("WebAppCon") { }
    }
}