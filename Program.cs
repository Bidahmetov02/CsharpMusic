using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TestMVCApp.Data;
using TestMVCApp.Models;

namespace TestMVCApp
{
    public class Program
    {
        public void CreateData(AppDbContext db)
        {
            Customer c1 = new Customer
            {
                Name = "Beka", LastName = "Bidakhmetov", Address = "Broniewskiego 26", 
                Email = "bidahmetov2002@gmail.com", CardNumber = 1234567
            };
            Customer c2 = new Customer
            {
                Name = "Noni", LastName = "Kadirbekova", Address = "Broniewskiego 24", 
                Email = "Noyana@email.com", CardNumber = 90909
            };

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

            Busket b1 = new Busket
            {
                Customer = c1, Products = {p1, p2}
            };

            Order o1 = new Order
            {
                UserId = 1, Date = DateTime.Now, Products = {p1, p2},
                Total = (p1.Price + p2.Price)
            };

            db.Add(c1);
            db.Add(c2);
            db.Add(p1);
            db.Add(p2);
            db.Add(b1);
            db.Add(o1);

            db.SaveChanges();
        }
        
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
