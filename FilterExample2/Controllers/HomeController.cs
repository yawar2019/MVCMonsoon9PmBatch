using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterExample2.Controllers
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
        
        public ActionResult Contact(string id)
        {
            try
            {
                int EmpId = Convert.ToInt32(id);
                ViewBag.info = EmpId;
                return View();
            }
            catch(Exception ex) {

                throw ex;
            }
           
        }
    }
}