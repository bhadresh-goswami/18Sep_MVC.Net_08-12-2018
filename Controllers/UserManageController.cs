using PartialViewExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewExample.Controllers
{
    public class UserManageController : Controller
    {
        // GET: UserManage
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserModel userModel)
        {
            try
            {
                //for show error
               // int a = int.Parse(userModel.UserPassword);
                if (userModel.UserName == "abc" && userModel.UserPassword == "123")
                {
                    
                    Session["userId"] = 1;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["error"] = "User Name or Password is Wrong!";
                }
            }
            catch (Exception ex)
            {

                TempData["error"] = "Server Side error: " + ex.Message;
                return RedirectToAction("ErrorShow");
            }
            return View();
        }
        public ActionResult ErrorShow()
        {
            return View();
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            TempData["message"] = "Successfully LogOut!";
            return RedirectToAction("Login","UserManage");
        }
    }
}