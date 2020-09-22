using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMonsoon9PmBatch.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
    }
    public class TestEmployeeModel
    {
        public List<EmployeeModel> listemp { get; set; }
        public List<Department> listdept { get; set; }
    }
}