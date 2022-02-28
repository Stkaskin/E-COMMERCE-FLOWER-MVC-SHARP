using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CicekSepeti.Controllers
{
    public class LayoutPage : Controller
    {
        // GET: Page
        public ActionResult LayoutHomePage()
        {
            return View();
        }
        public ActionResult LayoutOrderPage() { return View(); }
        public ActionResult LayoutAdmin() { return View(); }
        public ActionResult LayoutAdminNED() { return View(); }
     
    }
}