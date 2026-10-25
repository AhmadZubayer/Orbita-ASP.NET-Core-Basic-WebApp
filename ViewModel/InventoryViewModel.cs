using Orbita_ProductTrackingApp_ASP.NET_Core.Models;
namespace Orbita_ProductTrackingApp_ASP.NET_Core.ViewModel

{
    public class InventoryViewModel
    {
        public Supplier Supplier { get; set; } = new Supplier("","","");
        public List <Product> Product { get; set; } = new List<Product>();

    }
    
}
