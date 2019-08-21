using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCRoulette.Models;

namespace MVCRoulette.Controllers
{
    public class ResultsController : Controller
    {
        RouletteServices RS = new RouletteServices();
        public ActionResult Results()
        {
            return View();
        }
    }
}