using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class CustomerDbContext: DbContext
    {
        public DbSet<Customer> customers { get; set; }
    }
}