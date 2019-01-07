using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void auth(string mail, string pass)
        {
            //Session["mail"] = mail;
            //string checkau = HttpContext.User.Identity.Name;
            HttpContext.Response.Cookies["mail"].Value = mail;
            var _mail = HttpContext.Response.Cookies["mail"].Value;
            
            //return 
        }

        public void logout()
        {
            //HttpContext.Response.Cookies.Clear();
            HttpContext.Response.Cookies["mail"].Value = "";
        }
    }
}