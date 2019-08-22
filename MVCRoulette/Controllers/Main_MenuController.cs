using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCRoulette.Models;

namespace MVCRoulette.Controllers
{
    public class Main_MenuController : Controller
    {
        Users user = new Users();
        public ActionResult MainMenu()
        {
            using (RouletteEntities db = new RouletteEntities())
            {
                return View(user);
            }
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "Red")]
        public ActionResult ButtonRed(Users user)
        {
            BusinessEnitites.UserServices userServices = new BusinessEnitites.UserServices();
            user.Guess = "Red";
            userServices.UserGuess(user);
            return RedirectToAction("Bet", "BetCheck");
        }
        //            if (ModelState.IsValid)
        //    {
        //        user.Guess = "Red";
        //        BusinessEnitites.UserServices userServices = new BusinessEnitites.UserServices();
        //userServices.UserGuess(user);
        //    }
    [HttpPost]
        [MultipleButton(Name = "action", Argument = "White")]
        public ActionResult ButtonWhite(Users user)
        {
            return RedirectToAction("Bet", "BetCheck");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "Black")]
        public ActionResult ButtonBlack(Users user)
        {
            return RedirectToAction("Bet", "BetCheck");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "Green")]
        public ActionResult ButtonGreen(Users user)
        {
            return RedirectToAction("Bet", "BetCheck");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "Even")]
        public ActionResult ButtonEven(Users user)
        {
            return RedirectToAction("Bet", "BetCheck");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "Odd")]
        public ActionResult ButtonOdd(Users user)
        {
            return RedirectToAction("Bet", "BetCheck");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "First Half")]
        public ActionResult ButtonFH(Users user)
        {
            return RedirectToAction("Bet", "BetCheck");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "Second Half")]
        public ActionResult ButtonSH(Users user)
        {
            return RedirectToAction("Bet", "BetCheck");
        }
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class MultipleButtonAttribute : ActionNameSelectorAttribute
    {
        public string Name { get; set; }
        public string Argument { get; set; }

        public override bool IsValidName(ControllerContext controllerContext, string actionName, System.Reflection.MethodInfo methodInfo)
        {
            var isValidName = false;
            var keyValue = string.Format("{0}:{1}", Name, Argument);
            var value = controllerContext.Controller.ValueProvider.GetValue(keyValue);

            if (value != null)
            {
                controllerContext.Controller.ControllerContext.RouteData.Values[Name] = Argument;
                isValidName = true;
            }

            return isValidName;
        }
    }
}