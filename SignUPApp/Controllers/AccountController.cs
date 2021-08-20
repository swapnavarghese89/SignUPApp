using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SignUPApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SignUPApp.Controllers
{
    public class AccountController : Controller
    {
        //[Route("")]
        //[Route("Account")]
        //[Route("/Login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Username , string Password)
        {
            return View();
        }
        
        public IActionResult SignUp()
        {
            ViewBag.CountryList = new List<CountryModel> { new CountryModel { Country = "India", CountryId = "1" },
                new CountryModel { Country="USA",CountryId="2"},new CountryModel{Country="Japan",CountryId="3"}
                };

            return View();
        }
        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {
            //if (string.IsNullOrEmpty(model.Name))
            //{
            //    ModelState.AddModelError("Name", "Please enter the name");
            
            ViewBag.CountryList = new List<CountryModel> { new CountryModel { Country = "India", CountryId = "1" },
                new CountryModel { Country="USA",CountryId="2"},new CountryModel{Country="Japan",CountryId="3"}
                };
           
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(); 
        }
        
       [HttpGet]
        public JsonResult GetCityName(string CountryId)
        {
            IEnumerable<CityModel> Cities = new CityModel().GetCityNames().Where(x => x.CountryId == CountryId).ToList();

            return Json(new SelectList(Cities, "CityId", "CityName"));
        }




    }
}
