using lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            WebStoreEntities db = new WebStoreEntities();
            string mail = HttpContext.Request.Cookies["mail"].Value;
            //var dbStore = new STORE();

            if (mail != "")
            {
               var dbStore = db.STORE.Where(x => x.USERS.EMAIL == mail).ToList();
                return View(dbStore);
            }
            else
            {
                return View();
            }
            

            
        }

        public void addToStore(string name, string price, int kol, string mail)
        {
            WebStoreEntities db = new WebStoreEntities();
            STORE dbStore = new STORE();
            var dbUser = db.USERS.ToList();
            var dbProd = db.PRODUCTS.ToList();
            int idProd = dbProd.Single(x=>x.PRODUCTNAME == name).ID;
            //string mail = HttpContext.Response.Cookies["mail"].Value;
            int idUser = dbUser.Single(x=>x.EMAIL == mail).ID;

            dbStore.LOGIN_ID = idUser;
            dbStore.PROD_ID = idProd;
            dbStore.KOL = kol;
            db.STORE.Add(dbStore);
            db.SaveChanges();
        }
    }
}