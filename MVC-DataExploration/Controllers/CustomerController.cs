using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DataExploration.Models;

namespace MVC_DataExploration.Controllers
{
    public class CustomerController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: Customers
        public ActionResult Index()
        {
            return View(db.Customers);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(); // show the form ( the little boxes)
        }

        [HttpPost]
        public ActionResult Create(Customer MyCustomer)
        {
            // Add the new customer to my set of Customers 
            db.Customers.Add(MyCustomer);
            // Updates Changes
            db.SaveChanges();


            return View("Index", db.Customers); //show the updated Index page
        }
    }
}