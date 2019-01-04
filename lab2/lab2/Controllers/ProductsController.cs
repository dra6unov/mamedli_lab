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
            return View();
        }

        public ActionResult Notebook()
        {
            var AllNotebooks = db.PRODUCTS.Where(x => x.CATEGORY == "Ноутбуки").ToList();
            return View(AllNotebooks);
        }

        public ActionResult Smartwatch()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}