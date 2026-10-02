using Microsoft.AspNetCore.Mvc;

namespace ProductsRouting.Controllers
{
    public class ProductController : Controller
    {
        private readonly List<Product> _products =
            [
                new Product(1, "Murzik skotik", "Very naughty and stinky", "/images/murzik.jpg"),
                new Product(2, "Murka skotik", "Very naughty and stinky", "/images/murka.jpg"),
                new Product(3, "Mango sticky rice", "So tasty and nice", "/images/mangoStickyRice.jpg")
            ];
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            var objId = RouteData.Values["id"];
            if (objId != null)
            {
                var id = Convert.ToInt32(objId);
                var product = _products[id - 1];
                ViewBag.Product = product;
            }
            else throw new Exception("Product doesnt exist");
            return View();
        }
    }
}
