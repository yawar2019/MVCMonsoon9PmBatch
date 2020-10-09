using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExampleOnMigration.Models;
namespace ExampleOnMigration.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        EmployeeContext db = new EmployeeContext();
        EmployeeEntities db1 = new EmployeeEntities();
        
        public ActionResult Index()
        {
            return View(db.EmployeeModels.ToList());
        }

        public ActionResult HtmlHelperExample()
        {
            EmployeeModel emp = new EmployeeModel();
            ViewBag.Department = new SelectList(db1.Departments.ToList(),"DeptId", "DeptName",3);
            emp.Designation = "software developer";
            return View(emp);
        }
    }
}