﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary.Models;

namespace Factory_Design_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly BAL dal;
        public EmployeeController(BAL bAL )
        {
                dal = bAL;
        }

        
        [HttpGet]
        [Route("EmployeeList")]
        public IActionResult Get(int? id)
        {
            if (id.HasValue)
            {
                var employee = dal.GetEmployeeById(id.Value);
                return Ok(employee);
            }
            else
            {
                var employees = dal.GetEmployees();
                return Ok(employees);
            }

        }

        [HttpPost]
        [Route("CreateEmployee")]
        public IActionResult Create(Employee employee)
        {
            dal.CreateEmployee(employee);
            return Ok();
        }

        [HttpPut]
        [Route("UpdateEmployee")]
        public IActionResult Update(int id, Employee employee)
        {
            if (id != employee.Id)
                return BadRequest();


            dal.UpdateEmployee(employee);
            return Ok();
        }

        [HttpGet]
        [Route("Get OT")]
        public IActionResult OT(int Hourse, int employeeId)
        {
            
            return Ok(dal.GetOverTime(Hourse, employeeId));
        }

        [HttpDelete]
        [Route("DeleteEmployee")]
        public IActionResult Delete(int id)
        {
            dal.DeleteEmployee(id);
            return Ok();
        }
    }
}
