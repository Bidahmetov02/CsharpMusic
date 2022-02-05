using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestMVCApp.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        //public Customer Customer { get; set; } 
        public DateTime Date { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public decimal Total { get; set; }
    }
}

