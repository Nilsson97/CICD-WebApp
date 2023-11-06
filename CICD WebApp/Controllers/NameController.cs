using Microsoft.AspNetCore.Mvc;
using CICD_WebApp.Models;
using CICD_WebApp.Util;

namespace CICD_WebApp.Controllers
{
    public class NameController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index", new { nameIsValid = false, showNameEvaluation = false });
        }

        [HttpPost]
        public IActionResult ValidateName(FirstnameDTO personFN, LastnameDTO personLN)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", new {nameIsValid = false, showNameEvaluation = true });
            }

            //DI intentionally omittede here for clarity
            PersonRepository personRepository = new PersonRepository();

            Person personWithInvariance = new Person(personFN, personLN);

            personRepository.AddPerson(personWithInvariance);

            return View("Index", new { nameIsValid = true, showNameEvaluation = true });


        }

       
    }
}
