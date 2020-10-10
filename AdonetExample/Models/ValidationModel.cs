using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdonetExample.Models
{
    public class MOUZAMMODLE 
    {
        [Key]
        public int EmpId { get; set; }
        [Required(ErrorMessage ="EmpName Cannot be Empty")]
        [Display(Name ="Employee Name")]
        //[RegularExpression(@"^[A-za-z\d]{4}\d{6,7}$", ErrorMessage = "EmpName should first character and then Numbers")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "Password Cannot be Empty")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password and Confirm pwd MisMatch")]
        public string ConfirmPassword { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="Emaild is Invalid")]
        public string Emaild { get; set; }
        [Range(18,70,ErrorMessage ="18-70 is allowed")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Salary Cannot be Empty")]

        public int Salary { get; set; }
        [StringLength(10,ErrorMessage ="Only 10 Characters Are Allowed")]
        public string Address { get; set; }
    }
}