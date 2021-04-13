using CaptchaMvc.HtmlHelpers;
using MobileShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MobileShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        MobileManagementEntities1 db = new MobileManagementEntities1();
        public ActionResult Index()
        {
            return View();
        }
        //login
        [HttpGet]
        public ActionResult AccountLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AccountLogin(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                string userName = collection["txtusername"].ToString();
                string password = collection["txtpassword"].ToString();
              
                    //var f_password = GetMD5(password);
                    var data = db.Users.Where(s => s.UserName.Equals(userName) && s.Password.Equals(password)).ToList();

                    if (data.Count() > 0)
                    {
                        //add session
                        Session["FullName"] = data.FirstOrDefault().FullName;
                        return RedirectToAction("Index");
                        
                    }
                    else
                    {
                        
                        return Content("Account or password is incorrect");
                    }
            }
            return View();
            
        }
        public ActionResult Logout()
        {
            Session.Clear();//remove session
            return RedirectToAction("Index");
        }

        //register
        [HttpGet]
        public ActionResult Regiter()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Regiter(User user, FormCollection collection)
        {
            if (this.IsCaptchaValid("Captcha is not valid"))
            {
                ViewBag.mesage = "Successfully";
                db.Users.Add(user);
                db.SaveChanges();
                return View();
            }
            ViewBag.mesage = "Falied";
            return View();
        }

        //Password encryption
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }
        public ActionResult ViewCart()
        {
            return View();
        }

        public ActionResult CartPartial()
        {
            return PartialView();
        }
    }
}
