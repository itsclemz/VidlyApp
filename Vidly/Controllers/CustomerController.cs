using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        CustomerDbContext context = new CustomerDbContext();
        // GET: Customer
        public ActionResult Index()
        {
            return View(context.customers.ToList());  
        }
    }
}