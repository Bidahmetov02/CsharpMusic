using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Image")]
        public string ImgName { get; set; }
    }
}

