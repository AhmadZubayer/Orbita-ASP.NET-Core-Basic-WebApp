using System.ComponentModel.DataAnnotations;
namespace Orbita_ProductTrackingApp_ASP.NET_Core.Models
{
    public class Product
    {
        [Display(Name = "Product ID")]
        public int Id { get; set;}

        [Required(ErrorMessage = "Prodcut Name is Required")]
        public string Name { get; set;}

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public double Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage ="Quantity Cannot be negative")]
        public int Quantity { get; set; }
        
        
        public Product()
        {
            this.Name = "";
        }

        public Product(int id, string name, double price, int quantity)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
