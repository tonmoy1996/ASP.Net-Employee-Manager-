using CodeFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApp.Controllers
{
    public class EmployeeController : Controller
    {
        EMSContextDB context = new EMSContextDB();
        public ActionResult Index()
        {
            return View(context.Employees.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.departments = context.Departments.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee e)  
        {
            context.Employees.Add(e);
            context.SaveChanges();
            return RedirectToAction("Index");
        
        }
    }
}