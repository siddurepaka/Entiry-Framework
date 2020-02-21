using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeWeb.Models;
namespace EmployeeWeb.Controllers
{
    public class DefaultController : Controller
    {
        private readonly EmployeeManagement emprepository;//=new EmployeeRepository();
        public DefaultController(EmployeeManagement emRepos) 
        {
            emprepository = emRepos;

        }
        public IActionResult Search(int? id) 
        {
            int ID = (int)((id == null) ? 1 : id);
            Employee em= emprepository.GetEmployee(ID);
            //  return "fdsf";
            //if (em != null)
            //{
            //    return Content(em.id + " " + em.name + " " + em.Dept);
            //}
            //return Content("Employee Id doesn't exist");
            //ViewData["id"] = em.id;
            //ViewData["name"] = em.name;
            //ViewData["dept"] = em.Dept;
            //ViewBag.id = em.id;
            //ViewBag.name = em.name;
            //ViewBag.dept = em.Dept;
            //ViewData["employee"] = em;
           // ViewBag.employee = em;
            return View(em);
        }
        public IActionResult Index()
        {
            List<Employee> el = emprepository.DisplayDetails();
            return View(el);
        }
        public ViewResult AboutEmployee() 
        {
            Employee el1 = emprepository.GetEmployee(2);
            // ViewBag.ProjName = "C#";
            EmployeeProjectView ep = new EmployeeProjectView();
            ep.employee1 = el1;
            ep.projectName = "C#";
            return View(ep);
        }
        public IActionResult GetAllEmployees() 
        {
            List<Employee> el = (emprepository.DisplayDetails()).Where(e=>e.Dept==Dept.IT).ToList();
            return View("Index", el);
        }
        [HttpGet]
        public IActionResult Create() 
        {
            Employee el1 = emprepository.GetEmployee(2);
            return View(el1);
        }
        [HttpPost]
        public IActionResult Create(int id)
        {
            //Employee el1 = emprepository.GetEmployee(2);
            return View("Success");
        }
        public IActionResult Success() 
        {
            return View();
        }
        public IActionResult List()
        {
            List<Employee> elist = emprepository.DisplayDetails();
            return View(elist);
        }
        [HttpGet]
        public IActionResult Register() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Employee employ3)
        {
            bool re = emprepository.AddEmployee(employ3);
            return RedirectToAction("Index");
        }
       
    }
}