using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaHut.Models;

namespace PizzaHut.Controllers
{
    [Route("employee")]
    public class EmployeeController : Controller
    {
      
        public IActionResult Index()
        {
            Employee employee = new Employee { ID = 1, FirstName = "Valery", LastName = "Legasov", Title = "Chef", City = "Kiev", HireDate = new DateTime(1986, 04, 25) };
            ViewBag.Employee = employee;
            return View();
        }
    }
}