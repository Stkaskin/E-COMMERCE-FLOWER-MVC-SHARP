using CicekSepeti.Models.Database;
using CicekSepeti.Models.Model;
using CicekSepeti.Models.Table;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CicekSepeti.Controllers
{

    public class ProductPageController : Controller
    {
   
        ProductModel pModel = new ProductModel();
        BaseData db = new BaseData();
        // GET: Product
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Products()
        {
            Product product = new Product();
            pModel.ProductsTable = db.ProductDbTable.ToList();



            // pModel.ProductsTable = db.ProductDbTable.ToList();
            return View(pModel);
        }
        public ActionResult Productdetail(int? id)
        {//Burada kullancagımız model önceki baktıklarımızı ,katagori ve ürün bilgilerini içeren  model olacaktır.-
         //tıklanma sayısını artır
            List<SelectListItem> kategoriler = new List<SelectListItem>();
            SehirModel sehir = new SehirModel();
            //sehir.İllerTable = db.illerTable.ToList();
            //sehir.İlcelerTable = db.ilcelerTable.ToList();
            //Response.Write("Session:" + Session.LCID);
            //Response.Write("Session:" + Session.SessionID);



            pModel.ProductsTable = db.ProductDbTable.Where(x => x.id == id).ToList();

            foreach (var item in db.illerTable.ToList())
            {
                kategoriler.Add(new SelectListItem { Text = item.sehiradi, Value = item.id.ToString() });
            }
            ViewBag.Kategoriler = kategoriler;
            // db.SaveChanges();
            LastProductControl(pModel.ProductsTable.FirstOrDefault(), pModel);
            return View(pModel);
        }
        private void LastProductControl(Product product, ProductModel model)
        {
            LinkedList<Product> lastproducts = new LinkedList<Product>();
            Product silinecek = new Product();
            bool varyok = false;
            object ob = Session["lastproducts"];
            if (ob != null)
                lastproducts = (LinkedList<Product>)Session["lastproducts"];

            foreach (var item in lastproducts)
            {
                if (item.id == product.id)
                {
                    varyok = true;
                    silinecek = item;
                    break;
                }
            }
            if (varyok)
            {
                lastproducts.Remove(silinecek);
            }
            lastproducts.AddFirst(product);
            if (lastproducts.Count > 4) { lastproducts.RemoveLast(); }

            Session.Add("lastproducts", lastproducts);
            model.lastproducts = lastproducts;
            //Response.Write("\nLast Product count:" + lastproducts.Count);

        }
        [HttpPost, ActionName("Productdetail")]
        public ActionResult Productdetails(int? id)
        {
            Product product = new Product();
            product = db.ProductDbTable.Where(x => x.id == id).FirstOrDefault();
            Session.Add("sepet", product);
            ViewBag.siparis = product;
            return RedirectToAction("LogIn", "Order");
        }

        public ActionResult Cart()
        {
            Product product = new Product();
            pModel.ProductsTable = db.ProductDbTable.ToList();



         
            return View(pModel);
        }

        [HttpPost]
        public ActionResult Search()
        {
            Response.Redirect("asdassd");
            return View();
        }


    }
}