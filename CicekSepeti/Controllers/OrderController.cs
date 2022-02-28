using CicekSepeti.Models.Database;
using CicekSepeti.Models.Model;
using CicekSepeti.Models.Table;
using CicekSepeti.Models.Table.others;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CicekSepeti.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        
        public ActionResult LogIn()
        {
            return View();
        }
        public ActionResult Order()
        {
            
            Product product = new Product();
  

            object objProduct = Session["sepet"];
            OrderAndProduct OP = new OrderAndProduct();
            OP.Product = (Product)objProduct;
        
            //deneme amaclı
            product.id = 1;
            product.name = "deneme";
            OP.Product = product;
            objProduct = 1;
            //

            Response.Write("0");
            if (objProduct != null)
                return View (OP);
            else
            {

                return RedirectToAction("LogIn", "Order");
            }
        }
        [HttpPost]
        public ActionResult Control(OrderDetail order)
        {

            Session.Add("Orderdetail",order);
            return RedirectToAction("OrderNote", "Order");

            ///return Json(false);

        }
        public ActionResult OrderNote()
        {

            return View();
        }
        
        [HttpPost]
        public ActionResult OrderNoteControl(OrderDetail order)
        {

            OrderDetail detail = new OrderDetail();
            detail = (OrderDetail)Session["Orderdetail"];
            detail.Note = order.Note;
           
            Session["Orderdetail"] = detail;
            return RedirectToAction("Information", "Order");
        }

       
        public ActionResult Information()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InformationControl(Invoice ınvoice)
        {

            Session.Add("Invoice", ınvoice);
            return RedirectToAction("OrderPay","Order");
        }
        public ActionResult OrderPay()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OrderPayControl(Invoice ınvoice)
        {

            //Invoice inv = new Invoice();
            //inv = (Invoice)Session["Invoice"];
            //inv.name = order.Note;
            //inv.tel= order.NoteName;
            //inv.mail= order.NoteActive;
            //Session["Invoice"] = detail;
            return RedirectToAction("veritabaninagiris", "Order");

        }
        public ActionResult veritabaninagiris()
        {
            Invoice ınvoice = new Invoice();
            OrderDetail detail = new OrderDetail();
            BaseData db = new BaseData();

            ınvoice = (Invoice)Session["Invoice"];
            detail = (OrderDetail)Session["OrderDetail"];




            db.InvoiceTable.Add(ınvoice);
            db.OrderDetailTable.Add(detail);
            db.SaveChanges();
            Session.Remove("OrderDetail");
            Session.Remove("Invoice");
            return RedirectToAction("Products","ProductPage");
        }


    }
}