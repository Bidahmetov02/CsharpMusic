using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestMVCApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        //public IEnumerable<Product> Products { get; set; }
        [Display(Name = "Image")]
        public string ImgName { get; set; }
    }
}

