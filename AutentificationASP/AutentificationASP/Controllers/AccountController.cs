using AutentificationASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.Entity;

namespace AutentificationASP.Controllers
{
    public class AccountController : Controller
    {
        UserContext myDb = new UserContext();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user;
                using (UserContext db = new UserContext())
                {
                    user = db.Users.FirstOrDefault(u => u.Email == model.Name);
                }
                if (user != null)
                {
                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Name, true);
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Пользователь с таким логином и паролем нет");
            }

            return View(model);
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user;
                using (UserContext db = new UserContext())
                {
                    user = db.Users.FirstOrDefault(u => u.Email == model.Name);
                }
                if (user == null)
                {
                    using (UserContext db = new UserContext())
                    {
                        db.Users.Add(new User { Email = model.Name, Password = model.Password, RoleId = 2 });
                        db.SaveChanges();

                        user = db.Users.Where(u => u.Email == model.Name && u.Password == model.Password).FirstOrDefault();
                    }
                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Name, true);
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Пользователь с таким логином уже существует");
            }

            return View(model);
        }
        [Authorize(Roles = "admin")]
        public ActionResult Report1(int? town, string cityname)
        {
            IQueryable<CargoTransportation> cargoTransportation = myDb.CargoTransportations.Include(p => p.Town);
            if (town != null && town != 0)
            {
                cargoTransportation = cargoTransportation.Where(p => p.TownId == town);
            }
            if (!String.IsNullOrEmpty(cityname) && !cityname.Equals("All"))
            {
                cargoTransportation = cargoTransportation.Where(p => p.CityName == cityname);
            }

            List<Town> towns = myDb.Towns.ToList();
            towns.Insert(0, new Town { Name = "All", Id = 0 });

            CargoTransportationListViewModel ctvm = new CargoTransportationListViewModel
            {
                CargoTransportations = cargoTransportation.ToList(),
                Towns = new SelectList(towns, "Id", "Name"),
                CityNames = new SelectList(new List<string>() { "All", "Dnepr", "Kyev", "Odessa", "Lvov", "Kharkov" })
            };


            return View(ctvm);
        }
        [Authorize(Roles = "admin")]
        public ActionResult Report2()
        {
            return View();
        }
    }
}