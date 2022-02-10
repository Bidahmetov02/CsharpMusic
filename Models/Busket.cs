using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestMVCApp.Models
{
    public class Busket
    {
        [Key]
        public int Id { get; set; }
        /*[Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }*/
        public List<int> ProductId { get; set; } = new List<int>();
        public List<Product> Products { get; set; } = new List<Product>();
    }
} 