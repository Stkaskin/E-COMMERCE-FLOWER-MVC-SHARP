using CicekSepeti.Models.Database;
using CicekSepeti.Models.Table;
using CicekSepeti.Models.Table.others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CicekSepeti.Controllers
{
    public class AdminController : Controller
    {
        BaseData db = new BaseData();
        // GET: Admin
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Menu()
        {
                return View();
        }
        public ActionResult Category()
        {

            List<Category> model = new List<Category>();

            model = db.CatogoryDbTable.ToList();
            return View(model);
        }
        public ActionResult Products()
        {

            List<Product> model = new List<Product>();

            model = db.ProductDbTable.ToList();
            return View(model);
        }
        public ActionResult Users()
        {
            return View();
        }
        public ActionResult Orders()
        {
            List<OrderDetail> model = new List<OrderDetail>();

            model = db.OrderDetailTable.ToList();
            return View(model);
        }
   

    }
}