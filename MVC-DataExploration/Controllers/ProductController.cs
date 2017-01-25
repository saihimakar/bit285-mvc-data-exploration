﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DataExploration.Models;

namespace MVC_DataExploration.Controllers
{
    public class ProductController : Controller
    {
        private MyDBContext db = new MyDBContext();
        
        public ActionResult Index()
        {
            return View(db.Products);
        }
       
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Create(Product myProduct)
        {
            // Add the new customer to my set of Customers 
            db.Products.Add(myProduct);
            // Updates Changes
            db.SaveChanges();


            return View("Index", db.Products); //show the updated Index page
        }
    }
}