using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdonetExample.Models;
namespace AdonetExample.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        EmployeeDetail db = new EmployeeDetail();

        public ActionResult Index()
        {
            return View(db.GetEmployee());
        }
    }
}