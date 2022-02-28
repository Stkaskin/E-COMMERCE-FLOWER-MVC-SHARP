using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CicekSepeti.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult LogIn()
        {
            return View();
        }
        public ActionResult UserLogin()
        {

            return View();
        }  
        public ActionResult OrderNote()
        {

            return View();
        }     
    
     
        public ActionResult Information()
        {
            return View();
        } 
        public ActionResult OrderPay()
        {
            return View();
        }
 
        public ActionResult OrderTrack()
        {
            return View();
        }
        public ActionResult Support()
        {
            return View();
        }
    }
}