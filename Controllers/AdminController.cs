using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.CustomerList = _db.Customers;
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
        
        // ------------------Category---------------------
        // GET
        public IActionResult CreateCategory()
        {
            ViewBag.CategoriesList = _db.Categories;
            return View();
        }
        
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateCategoryPost(Category obj)
        {
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("CreateCategory");
        }
        
        // GET Delete
        public IActionResult DeleteCategory(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            
            return View(obj);
        }
        
        // POST Delete
        public IActionResult DeleteCategoryPost(int? id)
        {
            var obj = _db.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Categories.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("CreateCategory");
        }
        
        // GET Update
        public IActionResult UpdateCategory(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            
            return View(obj);
        }
        
        // POST Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateCategoryPost(Category obj)
        {
            _db.Categories.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("CreateCategory");
        }
        
    }
}