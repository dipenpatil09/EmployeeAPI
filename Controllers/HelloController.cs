using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        // GET: api/hello
        [HttpGet]
        public string SayHello()
        {
            return "Welcome to .NET Core API!";
        }

        // GET: api/hello/greet/{name}
        [HttpGet("greet/{name}")]
        public IActionResult Greet(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest("Name is required.");
            }

            var response = new
            {
                message = $"Hello {name}, welcome to Day 1 of your .NET Core journey!"
            };

            return Ok(response);
        }
    }
}
