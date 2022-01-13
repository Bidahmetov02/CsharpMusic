using System;
using System.Data.Common;
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
            
            /*Customer c1 = new Customer
            {
                Name = "Beka", LastName = "Bidakhmetov", Address = "Broniewskiego 26", 
                Email = "bidahmetov2002@gmail.com", CardNumber = 1234567
            };
            Customer c2 = new Customer
            {
                Name = "Noni", LastName = "Kadirbekova", Address = "Broniewskiego 24", 
                Email = "Noyana@email.com", CardNumber = 90909
            };
            _db.Customers.Add(c1);
            _db.Customers.Add(c2);
            
            Product p1 = new Product
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
            _db.Products.Add(p1);
            _db.Products.Add(p2);*/
            
            /*Busket b1 = new Busket
            {
                Customer = _db.Customers.Find(1), Products = {p1, p2}
            };
            _db.Buskets.Add(b1);*/
            /*Order o1 = new Order
            {
                UserId = 1, Date = DateTime.Now, Products = {p1, p2},
                Total = (p1.Price + p2.Price)
            };
            _db.Orders.Add(o1);*/
            
            _db.SaveChanges();

            return View();
        }
    }
}