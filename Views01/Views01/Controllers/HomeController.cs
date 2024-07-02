using Microsoft.AspNetCore.Mvc;
using Views01.Models;

namespace Views01.Controllers
{
    public class HomeController : Controller
    {

        [Route("home")]
        [Route("/")]
        public IActionResult Index()
        {

            ViewData["appTitle"] = "ASP.NET Core Demo App";

            List<Person> people = new List<Person>()
            {
                new Person(){Name="Frz", DateOfBirth=DateTime.Parse("2000-08-01"), PersonGender= Gender.Male},
                new Person(){Name="Ryu", DateOfBirth=DateTime.Parse("2005-08-01"), PersonGender= Gender.Female},
                new Person(){Name="Yoshi", DateOfBirth=DateTime.Parse("2002-08-01"), PersonGender= Gender.Other}
            };
            //  ViewData["people"] = people;
            //ViewBag.people = people;
            return View("Index", people); //Views/Home/Index.cshtml
                                          //   return View("abc"); //abc.cshtml
        }



        [Route("person-details/{name}")]
        public IActionResult Details(string? name)
        {
            if (name == null)
            {
                return Content("Person name can't be null");
            }

            List<Person> people = new List<Person>()
            {
                new Person(){Name="Frz", DateOfBirth=DateTime.Parse("2000-08-01"), PersonGender= Gender.Male},
                new Person(){Name="Ryu", DateOfBirth=DateTime.Parse("2005-08-01"), PersonGender= Gender.Female},
                new Person(){Name="Yoshi", DateOfBirth=DateTime.Parse("2002-08-01"), PersonGender= Gender.Other}
            };

            Person? matchingPerson = people.Where(temp => temp.Name == name).FirstOrDefault();

            return View(matchingPerson);
        }

        [Route("person-with-product")]
        public IActionResult PersonWithProduct()
        {
            Person person = new Person()
            {
                Name = "Depka",
                PersonGender = Gender.Female,
                DateOfBirth = Convert.ToDateTime("2004-04-02")
            };

            Product product = new Product()
            {
                ProductId = 1,
                ProductName = "Air Conditioner"
            };

            PersonAndProductWrapperModel personAndProductWrapperModel = new PersonAndProductWrapperModel()
            {
                PersonData = person,
                ProductData = product
            };

            return View(personAndProductWrapperModel);
        }

        [Route("home/all-products")]
        public IActionResult All()
        {
            return View();
        }
    }
}
