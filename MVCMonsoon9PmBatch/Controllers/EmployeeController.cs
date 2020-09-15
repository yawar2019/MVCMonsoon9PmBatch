using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMonsoon9PmBatch.Models;
namespace MVCMonsoon9PmBatch.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View("~/Views/Staff/GetMyView.cshtml");
        }

        public ViewResult GetEmployee()
        {

            EmployeeModel empobj = new EmployeeModel();
            empobj.EmpId = 1211;
            empobj.EmpName = "John";
            empobj.EmpSalary = 908765;

            ViewBag.EmpInfo = empobj;

            return View();
        }
        public ActionResult GetAllEmployee()
        {
            List<EmployeeModel> listobj = new List<EmployeeModel>();
            

            EmployeeModel empobj = new EmployeeModel();
            empobj.EmpId = 1211;
            empobj.EmpName = "John";
            empobj.EmpSalary = 908765;

            EmployeeModel empobj1 = new EmployeeModel();
            empobj1.EmpId = 1212;
            empobj1.EmpName = "Michael";
            empobj1.EmpSalary = 23423;

            EmployeeModel empobj2 = new EmployeeModel();
            empobj2.EmpId = 1213;
            empobj2.EmpName = "Ross";
            empobj2.EmpSalary = 73732;

            listobj.Add(empobj);
            listobj.Add(empobj1);
            listobj.Add(empobj2);


            ViewBag.EmpInfo = listobj;
             


            return View();
        }

        public ViewResult GetEmployeeByModel()
        {

            EmployeeModel empobj = new EmployeeModel();
            empobj.EmpId = 1211;
            empobj.EmpName = "John";
            empobj.EmpSalary = 908765;

          
            //object model = empobj;
            return View("GetEmployeeByModel", empobj);
        }

        public ActionResult GetAllEmployeeByModel()
        {
            List<EmployeeModel> listobj = new List<EmployeeModel>();

            EmployeeModel empobj = new EmployeeModel();
            empobj.EmpId = 1211;
            empobj.EmpName = "John";
            empobj.EmpSalary = 908765;

            EmployeeModel empobj1 = new EmployeeModel();
            empobj1.EmpId = 1212;
            empobj1.EmpName = "Michael";
            empobj1.EmpSalary = 23423;

            EmployeeModel empobj2 = new EmployeeModel();
            empobj2.EmpId = 1213;
            empobj2.EmpName = "Ross";
            empobj2.EmpSalary = 73732;

            listobj.Add(empobj);
            listobj.Add(empobj1);
            listobj.Add(empobj2);


            Department deptObj = new Models.Department();
            deptObj.DeptId = 1;
            deptObj.DeptName = "IT";

            ViewBag.dept = deptObj;


            //object model=listobj;
            return View(listobj);
        }


        public ActionResult GetAllEmployeeandDeptByModel()
        {
            List<EmployeeModel> listobj = new List<EmployeeModel>();

            EmployeeModel empobj = new EmployeeModel();
            empobj.EmpId = 1211;
            empobj.EmpName = "John";
            empobj.EmpSalary = 908765;

            EmployeeModel empobj1 = new EmployeeModel();
            empobj1.EmpId = 1212;
            empobj1.EmpName = "Michael";
            empobj1.EmpSalary = 23423;

            EmployeeModel empobj2 = new EmployeeModel();
            empobj2.EmpId = 1213;
            empobj2.EmpName = "Ross";
            empobj2.EmpSalary = 73732;

            listobj.Add(empobj);
            listobj.Add(empobj1);
            listobj.Add(empobj2);


            Department deptObj = new Models.Department();
            deptObj.DeptId = 1;
            deptObj.DeptName = "IT";

            EmpDept dbobj = new EmpDept();
            dbobj.emp = listobj;
            dbobj.dept = deptObj;



            //object model=listobj;
            return View(dbobj);
        }


        [HttpGet]
        public ViewResult SaveData()
        {

            return View("SaveData");
        }
    
        public RedirectResult getURl()
        {

            //return Redirect("http://www.google.com");
            return Redirect("~/Employee/SaveData");
        }


        public RedirectToRouteResult redirectMethod()
        {
            // return RedirectToAction("GetMyView","Staff",employeenmodeel);
            return RedirectToRoute("Default1");
        }

    }
}