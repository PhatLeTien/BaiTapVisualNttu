using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTTUAN5.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Product_Detail()
        {
            return View();
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}