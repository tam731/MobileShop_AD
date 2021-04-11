using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileShop.Models;

namespace MobileShop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ShopMobileManagementEntities db = new ShopMobileManagementEntities();
        public ActionResult Product1()
        {
            var listProduct = db.Products.Where(x => x.CategoryID == 1).ToList();
            ViewBag.listPro = listProduct;
            return View();
        }
        public ActionResult Product2()
        {
            return View();
        }
        public ActionResult ProductPartial()
        {
            var listProduct = db.Products.Where(x => x.CategoryID == 1).ToList();
            return PartialView(listProduct);
        }

    }
}