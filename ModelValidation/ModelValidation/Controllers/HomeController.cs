using Microsoft.AspNetCore.Mvc;
using ModelValidation.CustomModelBinder;
using ModelValidation.Model;

namespace ModelValidation.Controllers
{
    public class HomeController : Controller
    {



        //[Bind(nameof(Person.PersonName), nameof(Person.Email), nameof(Person.Password), nameof(Person.ConfirmPassword))]
        //[ModelBinder(BinderType = typeof(PersonModelBinder))]

        [Route("register")]
        //public IActionResult Index([FromBody]  Person person)
        public IActionResult Index(Person person, [FromHeader(Name ="User-Agent")] string UserAgent)
        {

         
            if(!ModelState.IsValid)
            {

                string errors = string.Join("\n", ModelState.Values.SelectMany(value => value.Errors).Select(error => error.ErrorMessage));
                return BadRequest(errors);

                //List<string> errorsList = new List<string>();
                //foreach (var value in ModelState.Values)
                //{
                //    foreach (var error in value.Errors)
                //    {
                //        errorsList.Add(error.ErrorMessage);
                //    }
                //}
                //string errors = string.Join("\n", errorsList);

            }
            return Content($"{person}, {UserAgent}");
        }
    }
}
