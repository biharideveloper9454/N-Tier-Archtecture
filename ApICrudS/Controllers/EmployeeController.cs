using ApICrudS.Contract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonLayer.Models;
using ApICrudS.Models;

namespace ApICrudS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee employeeService;

        //    private readonly ApplicationContext context;

        //    public EmployeeController(ApplicationContext context)
        //    {
        //        this.context = context;
        //    }
        public EmployeeController(IEmployee employeeService)
        {
            this.employeeService = employeeService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var emps = employeeService.GetEmployees();
            if (emps.Count == 0)
            {
                return NotFound();
            }

            return Ok(emps);
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
           var emp= employeeService.CreateEmployee(employee);
            return Ok(emp);
        }

        public IActionResult Delete(int id)
        {
            var emp = employeeService.DeleteEmployee(id);
            return Ok(emp);
        }
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            if (employee == null)
            {
                return BadRequest();
            }
            else
            {
                var result = employeeService.CreateEmployee(employee);
                return Created("Get", result);
            }
        }
        public IActionResult Update(Employee employee)
        {
            var emp = employeeService.UpdateEmployee(employee);
            return Ok(emp);
        }
    }
}
