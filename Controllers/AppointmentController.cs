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
        public IActionResult Index()
        {
            
            //IEnumerable<Product> objlist = _db.Products.Include(x => x.Category).ToList();
            
            return View();
        }
        
       
    }       
}