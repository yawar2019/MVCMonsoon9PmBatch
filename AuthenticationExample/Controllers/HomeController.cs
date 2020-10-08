using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthenticationExample.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
       [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles ="Admin")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Authorize(Roles = "Manager")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize(Roles = "Admin",Users = "Saleem17@gmail.com")]
        public ActionResult Thanks()
        {
            ViewBag.Message = "Thanks page.";

            return View();
        }
    }
}