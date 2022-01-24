using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestMVCApp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
        public int CardNumber { get; set; }
    }
}