using Microsoft.AspNetCore.Mvc;

namespace ControllerExample.Controllers
{
   public class HomeController: Controller
    {

        [Route("home")]
        [Route("/")]
        public IActionResult Index(int id)
        {
           return Content("hello home", "text/plain");
        }


        [Route("about")]
 
        public string About()
        {
            return "About";
        }


        [Route("contact-us/{id}")]
        public string Contact()
        {
            return "Contact";
        }
    }
}
