using CodeFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApp.Controllers
{
    public class DepartmentController : Controller
    {
        EMSContextDB context = new EMSContextDB();
        public ActionResult Index()
        {
            return View(context.Departments.ToList());
        }

        [HttpGet]
        public ActionResult Create( )
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department d)
        {
            context.Departments.Add(d);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Department department= context.Departments.SingleOrDefault(d => d.Id == id);
            return View(department);
        }

        public ActionResult AllEmploye(int id)
        {
            Department dd= context.Departments.SingleOrDefault(p => p.Id == id);

            ViewBag.Dept_Name = dd.Name;
            List<Employee> employees = context.Employees.Where(p => p.DepartmentId == id).ToList();
            return View(employees);
        }
    }
}