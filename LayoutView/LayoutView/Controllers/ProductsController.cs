using Microsoft.AspNetCore.Mvc;

namespace LayoutView.Controllers
{
    public class ProductsController : Controller
    {
        [Route("products")]
        public IActionResult Index()
        {
            return View();
        }

        //Url: /search/1
        [Route("search/{productId?}")]
        public IActionResult Search(int? productId)
        {
            ViewData["ProductId"] = productId;
            return View();
        }


        [Route("order")]
        public IActionResult Order()
        {
            return View();
        }
    }
}
