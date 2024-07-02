using Microsoft.AspNetCore.Mvc;
using PartialViews.Models;

namespace PartialViews.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public IActionResult Index()
        {

            ViewData["ListTitle"] = "Cities";
            ViewData["ListItems"] = new List<string>()
            {
                "London",
                "Lagos",
                "Abuja",
                "Tokyo",
                "Kigali"
            };
            return View();
        }


        [Route("about")]
        public IActionResult About()
        {
            return View();
        }



        [Route("programming-languages")]
        public IActionResult ProgrammingLanguages()
        {
            ListModel listModel = new ListModel()
            {
                ListTitle = "Programming Languages",
                ListItems = new List<string>()
                {
                    "GO",
                    "Python",
                    "C#"
                }
            };
            return PartialView("_ListPartialView", listModel);
            
        }
    }
}
