using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstApp.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        [Display(Name="Employee Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name="Salary")]
        public string Salary { get; set; }

        [Required]
        [Column(Order =2)]
        public string Email { get; set; }
        [Required]
        public string Location { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}                                               