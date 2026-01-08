using Microsoft.AspNetCore.Mvc;

namespace SimpleApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private static List<string> Students = new() { "Ahmed", "Sara" };

        [HttpGet]
        public IActionResult GetStudents() => Ok(Students);

        [HttpPost]
        public IActionResult AddStudent([FromBody] string name)
        {
            Students.Add(name);
            return Ok("Student added");
        }

        [HttpDelete("{name}")]
        public IActionResult DeleteStudent(string name)
        {
            Students.Remove(name);
            return Ok("Student deleted");
        }
    }
}
