using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMonsoon9PmBatch.Models;
namespace MVCMonsoon9PmBatch.Controllers
{
    [RoutePrefix("Santhosini")]
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
        [Route("Birthday/party")]
        [Route("Engagement/party")]
        [Route("TeachersDay/party")]
        [Route("Friends/party")]

        public ViewResult SaveData()
        {

            return View();
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
        public ViewResult PartialViewExample()
        {

            EmployeeModel empobj = new EmployeeModel();
            empobj.EmpId = 1211;
            empobj.EmpName = "John";
            empobj.EmpSalary = 908765;

            return View(empobj);
        }
        public ContentResult GetContent(int? id) {

            if (id == 1)
            {
                return Content("Hello World");
            }
            else if (id == 2)
            {
                return Content("<p style=color:red>Hello World</p>");

            }
            else
            {
                return Content("<script>alert('Hello World');</script>");
            }
        }

        public ActionResult Test() {
            List<EmployeeModel> listemp = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "xyz";
            obj.EmpSalary = 100;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId =2;
            obj1.EmpName = "abc";
            obj1.EmpSalary = 200;

            listemp.Add(obj);
            listemp.Add(obj1);

            List<Department> listdep = new List<Department>();

            Department deptobj = new Department();
            deptobj.DeptId =1211;
            deptobj.DeptName ="IT";

            Department deptobj1 = new Department();
            deptobj1.DeptId = 1212;
            deptobj1.DeptName = "Network";

            listdep.Add(deptobj);
            listdep.Add(deptobj1);

            


            TestEmployeeModel tobj = new Models.TestEmployeeModel();
            tobj.listemp = listemp;
            tobj.listdept = listdep;


            return View(tobj);
        }

        public FileResult MyFile() {
            return File("~/Web.config","application/xml");
        }
        public FileResult DownloadMyFile()
        {
            return File("~/Web.config", "application/xml","myFirstfile");
        }

        public JsonResult GetJonData() {

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

            return Json(listobj,JsonRequestBehavior.AllowGet);
        }

    }
}