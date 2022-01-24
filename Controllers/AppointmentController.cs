using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
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
            
            /*
            Customer c2 = new Customer
            {
                Name = "Noni", LastName = "Kadirbekova", Address = "Broniewskiego 24", 
                Email = "Noyana@email.com", CardNumber = 90909
            };
            _db.Customers.Add(c1);
            _db.Customers.Add(c2);
            
            
            _db.Products.Add(p1);
            _db.Products.Add(p2);
            
            
            Order o1 = new Order
            {
                UserId = 1, Date = DateTime.Now, Products = {p1, p2},
                Total = (p1.Price + p2.Price)
            };
            _db.Orders.Add(o1);
            
            _db.SaveChanges();*/
            
            /*Customer c1 = new Customer
            {
                Name = "Beka", LastName = "Bidakhmetov", Address = "Broniewskiego 26", 
                Email = "bidahmetov2002@gmail.com", CardNumber = 1234567
            };*/
            /*Product p1 = new Product
            {
                Name = "Laptop", Price = 500, 
                Description = "Cool Laptop for Gaming, Otvechayo", 
                ImgUrl = "https//:img.com"
            };
            Product p2 = new Product
            {
                Name = "TV", Price = 1000, Description = "Ok tv for films",
                ImgUrl = "https//:img2.com"
            };
            Busket b2 = new Busket
            {
                CustomerId = 2, Products = {p1, p2}
            };
            _db.Buskets.Add(b2);
            _db.SaveChanges();*/

            /*var product = _db.Products.Find(1);
            var product2 = _db.Products.Find(3);
            var Busket = _db.Buskets.Find(3);
            /*Busket.Products.Add(product);#1#
            Busket.Products.Add(product2);
            Busket.Products.Add(product2);
            Busket.Products.Add(product2);
            
            _db.SaveChanges();
            Console.WriteLine(Busket.Id);
            Console.WriteLine(Busket.CustomerId);
            Console.WriteLine(Busket.Products.Count);
            Busket.Products.ForEach(p => Console.WriteLine(p.Description));*/
            
            
            IEnumerable<Product> objlist = _db.Products;
            
            return View(objlist);
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id)
        {
            var obj = _db.Products.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Products.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}