using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMonsoon9PmBatch.Models
{
    public class EmpDept
    {
        public List<EmployeeModel> emp { get; set; }
        public Department dept { get; set; }
    }
}