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
    public class NEDController : Controller
    {
        BaseData db = new BaseData();
        Category category = new Category();
        Product product = new Product();
        OrderDetail OrderDetail = new OrderDetail();
        // GET: NED
        public ActionResult CategoryEdit(int? id)
        {
            category = db.CatogoryDbTable.Where(x => x.id == id).FirstOrDefault();
         
            return View(category);
        }
        public ActionResult CategoryNew()
        {
            return View();
        }
        public ActionResult CategoryDelete(int? id)
        {
            category = db.CatogoryDbTable.Where(x => x.id == id).FirstOrDefault();

            return View(category);
        }
        public ActionResult ProductEdit(int? id)
        {
            product = db.ProductDbTable.Where(x => x.id == id).FirstOrDefault();

            return View(product);
        }
        public ActionResult ProductNew()
        {
            return View();
        }
        public ActionResult ProductDelete(int? id)
        {
            product = db.ProductDbTable.Where(x => x.id == id).FirstOrDefault();

            return View(product);
        }
        public ActionResult OrderEdit(int? id)
        {
            OrderDetail = db.OrderDetailTable.Where(x => x.id == id).FirstOrDefault();

            return View(OrderDetail);
        }
        public ActionResult OrderNew()
        {
            return View();
        }
        public ActionResult OrderDelete(int? id)
        {
            OrderDetail = db.OrderDetailTable.Where(x => x.id == id).FirstOrDefault();

            return View(OrderDetail);
        }
        public ActionResult UserEdit(int? id)
        {
            return View();
        }
        public ActionResult UserNew()
        {
            return View();
        }
        public ActionResult UserDelete(int? id)
        {
            return View();
        }
       
        //Post
    }
}