using Microsoft.AspNetCore.Mvc;
using Orbita_ProductTrackingApp_ASP.NET_Core.Models;
using Orbita_ProductTrackingApp_ASP.NET_Core.ViewModel;
using System.Linq;

namespace Orbita_ProductTrackingApp_ASP.NET_Core.Controllers
{
    [Route("products")]
    public class ProductController : Controller
    {
        private List<Product> productList;
        public ProductController()
        {
            productList = new List<Product>
            {
                new Product(1, "Lenovo Laptop", 800.00, 10),
                new Product(2, "HP Laptop", 750.00, 15),
                new Product(3, "Dell Laptop", 900.00, 5),
                new Product(4, "Asus Laptop", 850.00, 8),
                new Product(5, "Acer Laptop", 700.00, 12)
            };
        }


        public IActionResult Index()
        {
            return Content("This is the product default page");
        }
        
        [Route("all")]
        [Route("/")]
        public IActionResult AllProducts()
        {
            return View(this.productList);
        }


        [Route("{id:int:max(50)}")]
        public IActionResult ProductDetails(int id)
        {
            var data = productList.Where(x => x.Id == id).FirstOrDefault();
            //if (data == null)
            //{
            //    return Content("No Product Found");
            //}
            //return View(data);

            if (data == null)
            {
                ViewData["Msg"] = "No Product Found :(";
                ViewBag.State = false;
            } else
            {
                ViewBag.State = true;
            }
            return View(data);
        }


        [HttpGet]
        [Route("add")]
        public IActionResult AddProduct()
        {
            return View(new Product());
        }
        
        [HttpPost]
        [Route("add")]
        public IActionResult AddProduct(Product p)
        {
            if (ModelState.IsValid)
            {
                productList.Add(p);
                return View("AllProducts", this.productList);
            }
            else
            {
                return View(p);
            }
        }
        

        [Route("inventory")]
        public IActionResult Inventory()
        {
            Supplier supplier = new Supplier ("Global Suppliers Inc.", "info@global-suppliers.com", "1-800-123-4567");
            var data = new InventoryViewModel();
            data.Supplier = supplier;
            data.Product = productList;
            return View(data);
        }
    }
}
