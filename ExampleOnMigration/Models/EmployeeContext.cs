using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExampleOnMigration.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext():base("EmployeeContext")
        {

        }

        public DbSet<EmployeeModel> EmployeeModels { get; set; }
    }
}