using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApp.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name="Department Name")]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}