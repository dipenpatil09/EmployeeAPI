using EmployeeAPI.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController: ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("{id}")]
        public ActionResult GetEmployeeById(int id) 
        {
            if (id < 0)
                return BadRequest("Invalid Id");
            var employee = _employeeService.GetById(id);
            return Ok(employee);
        }
    }
}
