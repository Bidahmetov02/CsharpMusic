using System;
using System.Collections.Generic;

namespace TestMVCApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        //public Customer Customer { get; set; } 
        public DateTime Date { get; set; }
        public List<Product> Products { get; set; }
        public decimal Total { get; set; }
    }
}