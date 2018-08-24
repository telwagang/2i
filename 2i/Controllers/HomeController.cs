using _2i.Models;
using API.Helpers;
using API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2i.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UserForm()
        {
            return View("UserForm"); 
        }

        public ActionResult ViewGrid()
        {
            var list = Sys.Get<I2iUsersController>().GetAllUsers();

            return View(list); 
        }
    }
}