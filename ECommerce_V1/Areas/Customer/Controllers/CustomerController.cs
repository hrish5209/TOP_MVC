using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerce_V1.EDM;

namespace ECommerce_V1.Areas.Customer.Controllers
{
    public class CustomerController : Controller
    {
        ECommerceEntities ee = new ECommerceEntities();
        // GET: Customer/Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Brands()
        {
            return View();
        }

        public ActionResult Testimonial()
        {
            return View();
        }

        public ActionResult Why()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string Email = fc["email"];
            string PWD = fc["pwd"];

            var obj = ee.tbl_Customer.Where(c => c.Email == Email && c.PWD == PWD).FirstOrDefault();
            if (obj != null)
            {
                Session["UserId"] = obj.UserId;
                Session["FirstName"] = obj.FirstName;
                return RedirectToAction("HomePage");
            }
            else
            {
                ViewBag.loginerror = "Invalid User or Password";
            }
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult HomePage()
        {
            return View();
        }
    }
}