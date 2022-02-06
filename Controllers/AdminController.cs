using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
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
        
        // ------------------Product---------------------
        // GET Create
        public IActionResult CreateProduct()
        {
            ViewBag.ProductsList = _db.Products.ToList();
            ViewBag.CategoryList = _db.Categories.ToList();
            return View();
        }
        
        // POST Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateProductPost(Product obj)
        {
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Price);
            Console.WriteLine(obj.Description);
            _db.Products.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        // Get Delete
        public IActionResult ProductDelete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Products.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            var CategoryId = obj.CategoryId;
            ViewBag.Category = _db.Categories.Find(CategoryId).Title;
            return View(obj);
        }
        
        // Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ProductDeletePost(int? id)
        {
            var obj = _db.Products.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Products.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("CreateProduct");
        }
        
        // Get Update
        public IActionResult UpdateProduct(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Products.Find(id);
            
            if (obj == null)
            {
                return NotFound();
            }
            
            ViewBag.CategoryList = _db.Categories.ToList();
            return View(obj);
        }
        
        // Post Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateProductPost(Product obj)
        {
            _db.Products.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("CreateProduct");
        }
        
        // ------------------Customer---------------------
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
        
        // GET Delete
        public IActionResult DeleteCustomer(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Customers.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            //Console.WriteLine(obj.Title);
            
            return View(obj);
        }
        
        // POST Delete
        public IActionResult DeleteCustomerPost(int? id)
        {
            var obj = _db.Customers.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Customers.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("CreateCustomer");
        }
        
        // GET Update
        public IActionResult UpdateCustomer(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Customers.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            
            return View(obj);
        }
        
        // POST Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateCustomerPost(Customer obj)
        {
            _db.Customers.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("CreateCustomer");
        }
        
        
        
        // ------------------Busket---------------------
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
        
        // ------------------Order---------------------
        // GET
        public IActionResult CreateOrder()
        {
            return View();
        }
        
        // ------------------Category---------------------
        // GET
        public IActionResult CreateCategory()
        {
            ViewBag.CategoriesList = _db.Categories.Include(x => x.Products);
            ViewBag.ProductsList = _db.Products;
            return View();
        }
        
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateCategoryPost(Category obj)
        {
            
            Console.WriteLine(obj.Title);
            Console.WriteLine(obj.Products.Count);
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

            //Console.WriteLine(obj.Title);
            
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