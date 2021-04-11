using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileShop.Models;

namespace MobileShop.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        MobileManagementEntities db = new MobileManagementEntities();
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
            List<User> user =db.Users.OrderBy(x=>x.Name).ToList();
            return View(user);
        }
        public ActionResult UserGroup()
        {
            List<User> user = db.Users.OrderBy(x => x.Name).ToList();
            return View(user);
        }
        public ActionResult Account()
        {
            return View();
        }
    }
}