using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTTUAN5.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Bloglist()
        {
            return View();
        }
        public ActionResult BlogSingle()
        {
            return View();
        }
    }
}