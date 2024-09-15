using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace demohelpertag.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        [Required]        
        public string ProductName { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public bool Catogary { get; set; }
        [Required]
        [Range(0, 10, ErrorMessage = "invalid value.please enter value in range of 0 to 10")]
        public double rating { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Company { get; set; }

    }
}
