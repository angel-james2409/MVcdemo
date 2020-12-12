using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVcdemo.Models
{
    public class Context:DbContext
    {
        public Context() : base("cs") { }

        public DbSet<Customer> customers { get; set; }

        public DbSet<Booking> bookings { get; set; }
        public DbSet<Admin> admins { get; set; }
    }
}
