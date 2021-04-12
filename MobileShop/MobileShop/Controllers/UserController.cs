using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileShop.Models;
using CaptchaMvc.HtmlHelpers;
using CaptchaMvc;

namespace MobileShop.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        ShopMobileManagementEntities db = new ShopMobileManagementEntities();
        public ActionResult Index()
        {
            var listUsers = db.Users.ToList();
            return View(listUsers);
        }
        public ActionResult Index1()
        {
            var listUsers = db.Users.ToList();
            return View(listUsers);
        }
        public ActionResult UserDetail()
        {
            User u = db.Users.Where(x => x.ID == 2).FirstOrDefault();
            return View(u);
        }
       
       
    }
}