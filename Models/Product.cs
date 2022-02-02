using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace TestMVCApp.Models
{
    public class Product
    {
        [Key]
        public int Id { set; get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
        [Display(Name = "Image")]
        public string ImgName { get; set; }
    }
}

