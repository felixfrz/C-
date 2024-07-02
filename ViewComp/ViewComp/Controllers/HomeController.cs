using Microsoft.AspNetCore.Mvc;
using ViewComp.Models;

namespace ViewComp.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }


        [Route("about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("friends-list")]
        public IActionResult LoadFriendsList()
        {

            PersonGridModel personGridModel2 = new PersonGridModel()
            {
                GridTitle = "Friends",
                Persons = new List<Person>()
        {
            new Person(){PersonName = "Jack", JobTitle="Data Engineer"},
            new Person(){PersonName = "Will", JobTitle = "Software Tester"}
        }
            };
            return ViewComponent("Grid", new {grid=personGridModel2});
        }
    }
}
