using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodingProject.Models;

namespace CodingProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Fruits()
        {
            var fruitsViewModel = new FruitsViewModel();
            return View(fruitsViewModel.GetFruits());
        }

    }
}