using DoctorWebForum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OnlineActiveUsers;

namespace DoctorWebForum.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        //Used to connect to database DBSets(Objects)
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            //Used to send number of registered users to home controller index page view 
            var UsersRegistered = _context.Users.Count();
            ViewBag.UsersRegistered = UsersRegistered;

            //Checks and renders any popups that have been sent from other controllers
            if (TempData["Popup"] != null)
                ViewBag.Popup = TempData["Popup"];

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
    }
}