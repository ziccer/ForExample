using AutentificationASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutentificationASP.Controllers
{
    public class HomeController : Controller
    {
        UserContext db = new UserContext();
        public ActionResult Index()
        {
            ViewBag.UserLogin = "Your are not logged in. Please Sign in...";
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.UserLogin = "You are logged in as: " + User.Identity.Name.ToString();
            }
            ViewBag.Autentication = db.Users;
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
    }
}