using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Security.Cryptography;
using System.Web.Security;
using Login_Logout_SignUp.Models;
using System.IO;

namespace Login_Logout_SignUp.Controllers
{
    public class Accounts_Controller : Controller
    {
        // GET: Accounts_
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            using (EmployeeDBContext context = new EmployeeDBContext())
            {
                model.UserPassword = GetMD5(model.UserPassword);
                bool IsValidUser = context.Users.Any(User => User.UserName.ToLower() == model.UserName.ToLower() && User.UserPassword == model.UserPassword);
                if (IsValidUser)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "Employees");
                }
                ModelState.AddModelError("", "invalid UserName or Password");
                return View();
            }
        }
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(User model)
        {
            using (EmployeeDBContext context = new EmployeeDBContext())
            {
                model.UserPassword = GetMD5(model.UserPassword);
                context.Users.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("Login");
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null; 
            for (int i=0; i<targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");
            }
            return byte2String;
        }
    }
}