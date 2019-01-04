using lab2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2.Controllers
{
    public class AddProductController : Controller
    {
        // GET: AddProduct
        public ActionResult Add()
        {
            return View();
        }

        public string name;

        [HttpPost]
        public ActionResult Add(string productName, string productProizv, string productDesc, string productPrice, string category)
        {
            WebStoreEntities db = new WebStoreEntities();
            PRODUCTS prod = new PRODUCTS();
            name = productName;

            prod.PRODUCTNAME = productName;
            prod.DESCR = productDesc;
            prod.MANUFACT = productProizv;
            prod.PRICE = productPrice;
            prod.CATEGORY = category;
            db.PRODUCTS.Add(prod);
            db.SaveChanges();
            return View();
        }
    }
}