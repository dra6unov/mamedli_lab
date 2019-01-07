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
            if(adress != "")
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
            Console.WriteLine("42352346t");
            //return View();
            return RedirectToAction("Index","Index");
        }

        
    }
}