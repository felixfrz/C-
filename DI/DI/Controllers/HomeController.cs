using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

namespace DI.Controllers
{
    public class HomeController : Controller
    {

        private readonly ICountriesService _countriesService;
        public HomeController(ICountriesService countriesService)
        {
            _countriesService = countriesService;
        }

        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.ID = _countriesService.CountryID;
         List<string> countries = _countriesService.GetCountries();

            return View(countries);
        }
    }
}
