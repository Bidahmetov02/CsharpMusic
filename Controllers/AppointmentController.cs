using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestMVCApp.Data;
using TestMVCApp.Models;

namespace TestMVCApp.Controllers
{
    public class Appointment : Controller
    {
        private readonly AppDbContext _db;

        public Appointment(AppDbContext db)
        {
            _db = db;
        }
        
        // GET
        public IActionResult Index(int? id)
        {
            ViewBag.p = _db.Products.Find(id);
            ViewBag.pId = id;
            return View();
        }

        public IActionResult Thankyou()
        {
            return View();
        }
        
        public IActionResult Buy(Customer obj)
        {
            _db.Customers.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Thankyou");
        }
    }       
}