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
        public ActionResult Main_Menu()
        {
            using (RouletteEntities1 db = new RouletteEntities1())
            {
                return View(user);
            }
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "Red")]
        public ActionResult ButtonRed(Roulette roulette)
        {
            roulette.Guess = "Red";
            return RedirectToAction("Bet", "BetCheck");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "White")]
        public ActionResult ButtonWhite(Roulette roulette)
        {
            roulette.Guess = "White";
            return RedirectToAction("Bet", "BetCheck");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "Black")]
        public ActionResult ButtonBlack(Roulette roulette)
        {
            roulette.Guess = "Blakc";
            return RedirectToAction("Bet", "BetCheck");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "Green")]
        public ActionResult ButtonGreen(Roulette roulette)
        {
            roulette.Guess = "Green";
            return RedirectToAction("Bet", "BetCheck");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "Even")]
        public ActionResult ButtonEven(Roulette roulette)
        {
            roulette.Guess = "Even";
            return RedirectToAction("Bet", "BetCheck");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "Odd")]
        public ActionResult ButtonOdd(Roulette roulette)
        {
            roulette.Guess = "Odd";
            return RedirectToAction("Bet", "BetCheck");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "First Half")]
        public ActionResult ButtonFH(Roulette roulette)
        {
            roulette.Guess = "FirstHalf";
            return RedirectToAction("Bet", "BetCheck");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "Second Half")]
        public ActionResult ButtonSH(Roulette roulette)
        {
            roulette.Guess = "SecondHalf";
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