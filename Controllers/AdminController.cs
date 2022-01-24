using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestMVCApp.Data;
using TestMVCApp.Models;

namespace TestMVCApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _db;

        public AdminController(AppDbContext db)
        {
            _db = db;
        }
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        // GET
        public IActionResult CreateProduct()
        {
            return View();
        }
        
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateProduct(Product obj)
        {
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Price);
            Console.WriteLine(obj.Description);
            _db.Products.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        // GET
        public IActionResult CreateCustomer()
        {
            return View();
        }
        
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateCustomer(Customer obj)
        {
            _db.Customers.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        // GET
        public IActionResult CreateBusket()
        {
            ViewBag.Products = _db.Products;
            return View();
        }
        
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateBusket(Busket obj)
        {
            _db.Buskets.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        // GET
        public IActionResult CreateOrder()
        {
            return View();
        }
    }
}