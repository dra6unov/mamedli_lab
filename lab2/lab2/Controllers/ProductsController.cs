using lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2.Controllers
{
    public class ProductsController : Controller
    {
        public WebStoreEntities db = new WebStoreEntities();
        // GET: Products
        //[HttpGet]
        public ActionResult Smartphone()
        {
            var AllSmartphones = db.PRODUCTS.Where(x => x.CATEGORY == "mobile").ToList();
            return View(AllSmartphones);
        }

        public ActionResult Notebook()
        {
            var AllNotebooks = db.PRODUCTS.Where(x => x.CATEGORY == "notebook").ToList();
            return View(AllNotebooks);
        }

        public ActionResult Smartwatch()
        {
            var AllSmartwatchs = db.PRODUCTS.Where(x => x.CATEGORY == "smartwatch").ToList();
            return View(AllSmartwatchs);
        }

        //[HttpPost]
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}