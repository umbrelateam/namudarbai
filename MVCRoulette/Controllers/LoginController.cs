using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRoulette.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authorize(Models.Users userModel)
        {
            using (Models.RouletteEntities db = new Models.RouletteEntities())
            {
                var userDetails = db.Users.Where(u => u.Username == userModel.Username && u.Password == userModel.Password).FirstOrDefault();
                if (userDetails == null)
                {
                    userModel.LoginErrorMessage = "Wrong username or password";
                    return View("Login", userModel);
                }
                else
                {
                    Session["Username"] = userDetails.Username;
                    Session["UserID"] = userDetails.UserID;
                    Session["Balance"] = userDetails.Balance;
                    Session["Attempts"] = userDetails.Attempts;
                    return RedirectToAction("MainMenu", "Main_Menu");
                }
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Login");
        }
    }
}