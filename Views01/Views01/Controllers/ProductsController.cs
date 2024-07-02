using Microsoft.AspNetCore.Mvc;

namespace Views01.Controllers
{
    public class ProductsController : Controller
    {

        [Route("products/all")]
        public IActionResult All()
        {
            return View();
        }
    }
}
