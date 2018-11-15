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
            CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();
            ViewBag.ItemsList = ORM.Items.ToList();
           
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
        
        public ActionResult AddUser(User newUser)
        {
            
            if (ModelState.IsValid)
            {
                ViewBag.WelcomeMessage = $"Welcome {newUser.FirstName}!";
                CoffeeShopDBEntities DataBase = new CoffeeShopDBEntities();
                DataBase.Users.Add(newUser);
                return View("SummaryConfirmation");
            }
            else
            {
                return View("Error");
            }
            
        }

        public ActionResult UserRegistration()
        {
            return View();
        }

        // 1. Make a new action with parameters for each input
        // 2. Validate each input (regex)
        // 3. If all inputs are valid, send them to Welcome page
        // 4. Otherwise, send them to an error page
    }

}