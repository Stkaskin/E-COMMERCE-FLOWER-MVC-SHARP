using CicekSepeti.Models.Table;
using CicekSepeti.Models.Table.others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CicekSepeti.Controllers
{
    public class NEDActiveController : Controller
    {
        // GET: NEDActive
        //POST

        [HttpPost]
        public ActionResult CategoryEdit(Category category)
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategoryNew(Category category)
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategoryDelete(Category category)
        {
            return View();
        }
        [HttpPost]
        public ActionResult ProductEdit(Product item)
        {
            return View();
        }
        [HttpPost]
        public ActionResult ProductNew(Product item)
        {
            return View();
        }
        [HttpPost]
        public ActionResult ProductDelete(Product item)
        {
            return View();
        }
        [HttpPost]
        public ActionResult OrderEdit(OrderDetail item)
        {
            return View();
        }
        [HttpPost]
        public ActionResult OrderNew(OrderDetail item)
        {
            return View();
        }
        [HttpPost]
        public ActionResult OrderDelete(OrderDetail item)
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserEdit(int? id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserNew()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserDelete(int? id)
        {
            return View();
        }
    }
}