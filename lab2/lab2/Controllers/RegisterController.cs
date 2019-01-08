using lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string firstName, string lastName, string email, string pass, string adress)
        {
            WebStoreEntities db = new WebStoreEntities();
            USERS user = new USERS();
            HttpContext.Response.Cookies["regSuccess"].Value = "";
            var dbUser = db.USERS.Where(x=>x.EMAIL == email).ToList();
            if(dbUser.Count > 0)
            {
                if (adress != "")
                {
                    user.ADRESS = adress;
                }
                user.FIRSTNAME = firstName;
                user.LASTNAME = lastName;
                user.EMAIL = email;
                user.PASS = pass;
                user.GRUP = "user";
                db.USERS.Add(user);
                db.SaveChanges();

                HttpContext.Response.Cookies["regSuccess"].Value = "";
                //return View();
                return RedirectToAction("Index", "Index");
            }
            else
            {
                //string success = "Электронная почта уже занята";
                HttpContext.Response.Cookies["regSuccess"].Value = "false";
                return View();
            }
            
        }

        
    }
}