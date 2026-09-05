using Microsoft.AspNetCore.Mvc;
using StudentApi.DTO;
using StudentApi.Mapper;
using StudentApi.Model.Domain;
using StudentApi.Model.DTO;
using StudentApi.Mapper;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        static List<Student> students = new List<Student>();

        [HttpGet("{id:int}")]
        public IActionResult GetStudent([FromRoute] int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                return Ok(student);
            }
            return NotFound();
        }

        [HttpGet("search")]
        public IActionResult SearchStudent([FromQuery] string name)
        {
            var result = students.Where(s => s.LastName.Contains(name) || s.FirstName.Contains(name));
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(students);
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] StudentAddDto dto)
        {
            students.Add(dto.MapToStudent());
            return Ok();
        }

        [HttpPut("{id:int}")]
        public IActionResult EditStudent(int id, [FromBody] StudentEditDto dto)
        {
            var studentForEdit = students.FirstOrDefault(s => s.Id == id);
            if (studentForEdit != null)
            {
                studentForEdit.Address = dto.Address;
                studentForEdit.Birthday = dto.Birthday;
                studentForEdit.Birthplace = dto.Birthplace;
            }
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
            }
            return Ok();
        }
    }
}
