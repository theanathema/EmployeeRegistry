using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeesRegister.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "You need to enter a last name.")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [StringLength(160, MinimumLength = 2)]
        public string LastName { get; set; }

        public int Salary { get; set; }

        public string Position { get; set; }

        public string Department { get; set; }
        public string Company { get; set; }

    }
}