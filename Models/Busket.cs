using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestMVCApp.Models
{
    public class Busket
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
    }
}