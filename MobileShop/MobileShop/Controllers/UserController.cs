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
        public ActionResult UserSort()
        {
            List<User> user =db.Users.OrderBy(x=>x.FullName).ToList();
            return View(user);
        }
        public ActionResult UserGroup()
        {
            List<User> user = db.Users.OrderBy(x => x.FullName).ToList();
            return View(user);
        }
        //register
        [HttpGet]
        public ActionResult Account()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Account(User user,FormCollection collection,string check)
        {
            if(this.IsCaptchaValid("Captcha is not valid"))
            {
                ViewBag.mesage = "Successfully";
                db.Users.Add(user);
                db.SaveChanges();
                return View();
            }
            ViewBag.mesage = "Falied";
            return View();
        }
    }
}