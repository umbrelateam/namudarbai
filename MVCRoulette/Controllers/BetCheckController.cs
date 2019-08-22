using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCRoulette.Models;

namespace MVCRoulette.Controllers
{
    public class BetCheckController : Controller
    {
        Roulette roulette = new Roulette();
        RouletteServices RS = new RouletteServices();
        public ActionResult Bet()
        {
            return View(roulette);
        }
        [HttpGet]
        public ActionResult BetCheck(Users userModel)
        {
            using (Models.RouletteEntities db = new RouletteEntities())
            {
                //var userBalance = db.Users.
                //if (userModel.Balance >= Session["Balance"])
            }
            return RedirectToAction("Results", "Results");
        }
    }
}