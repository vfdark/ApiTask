using Microsoft.AspNetCore.Mvc;

namespace SimpleApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : ControllerBase
    {
        // In-memory list of courses
        private static List<string> Courses = new() { "Math", "Programming" };

        // GET: api/courses
        [HttpGet]
        public IActionResult GetCourses()
        {
            return Ok(Courses);
        }

        // POST: api/courses
        // Body: "AI"
        [HttpPost]
        public IActionResult AddCourse([FromBody] string course)
        {
            Courses.Add(course);
            return Ok("Course added");
        }

        // DELETE: api/courses/{course}
        [HttpDelete("{course}")]
        public IActionResult DeleteCourse(string course)
        {
            Courses.Remove(course);
            return Ok("Course deleted");
        }
    }
}
