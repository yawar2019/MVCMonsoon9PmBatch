using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMonsoon9PmBatch.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public int getEmpid() {

            return 1211;
        }

        public string getEmpName(int? EmpId)
        {
            return "My Name is John and My EmpId is "+ EmpId;
        }

        public ActionResult GetMyView()
        {
            return View();

        }
    }
}