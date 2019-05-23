using BirthdayCardGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirthdayCardGenerator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(BirthdayCard birthdayCard )
        {

            if (ModelState.IsValid)
            {

                return View("CardSent", birthdayCard);
            }
            else
            {
                return View("Index", birthdayCard);
            }
        }
    }
}