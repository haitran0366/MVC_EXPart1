using Microsoft.AspNetCore.Mvc;
using MVC_EXPart1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_EXPart1.Controllers
{
    public class GreetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CountryDropdown()
        {
            CountryViewModel model = new CountryViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult CountryDropdown(CountryViewModel model)
        {
            var country = model.countryList.Find(x => x.countryID == model.countryID);
            ViewBag.greeting = country.greeting;
            return View(model);
        }

        public string Welcome()
        {
            return "This message is returned from Greeting/Welcome";
        }
    }
}
