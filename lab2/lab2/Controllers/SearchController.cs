using lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string searchItem)
        {
            WebStoreEntities db = new WebStoreEntities();
            var dbItem = db.PRODUCTS.Where(x => x.PRODUCTNAME == searchItem).ToList();
            if (dbItem.Count > 0)
            {
                return View(dbItem);
            }
                
            else
            {
                return View();
            }
                
        }


    }
}