using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CicekSepeti.Controllers
{
    public class ChangeController : Controller
    {
        // GET: Change
        public ActionResult Password()
        {
            return View();
        }
        public ActionResult Information()
        {
            return View();
        }
    }
}