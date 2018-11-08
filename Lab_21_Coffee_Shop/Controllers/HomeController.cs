using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_21_Coffee_Shop.Models;

namespace Lab_21_Coffee_Shop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult UserRegistration(string firstName, string lastName, string userEmail, string phoneNumber, string userPassword)
        {
            return View();
        }

        public ActionResult AddUser(User newUser)
        {
            if (ModelState.IsValid)
            {
                ViewBag.WelcomeMessage = $"Welcome {newUser.FirstName}!";
                return View("SummaryConfirmation");
            }
            else
            {
                return View("Error");
            }
            
        }

        // 1. Make a new action with parameters for each input
        // 2. Validate each input (regex)
        // 3. If all inputs are valid, send them to Welcome page
        // 4. Otherwise, send them to an error page
    }
}