using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdonetExample.Models;
using AdonetExample.Filter;
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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection frm)
        {
            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpName = Convert.ToString(frm["EmpName"]);
            emp.EmpSalary = Convert.ToInt32(frm["EmpSalary"]);
            int i = db.SaveEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.GetEmployeeById(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            int i = db.EditEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.GetEmployeeById(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]

        public ActionResult DeleteConfirmed(int? id)
        {
            int i = db.DeleteEmployeeById(id);

            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            };
        }
        //[ActionName("Delete")]
        //[HttpGet]
        //public ActionResult Deleted(int id)
        //{
        //    EmployeeModel emp = db.GetEmployeeById(id);
        //    return View(emp);
        //}

        public ActionResult ValidationEample()
        {

            return View();
        }

        //[HttpPost]
        //public ActionResult ValidationEample(ValidationModel vmd)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        return Redirect("~/Employee/ValidationEample");
        //    }
        //    else
        //    {
        //        return View(vmd);
        //    }

        //}
        [MyFilter]
        public ActionResult ExampleFilter() {
            ViewBag.Player = "Mahendra Bahubali";
            return View();
        }
    }
}