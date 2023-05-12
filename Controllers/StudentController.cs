using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAuthentication.Auth;
using ProjectAuthentication.Models;
using ProjectAuthentication.Repository;
using System.Data;

namespace ProjectAuthentication.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _context;

        public StudentController(IStudentRepository context)
        {
            _context = context;
        }

        

        [HttpPost]
        public ActionResult<ICollection<CourseController>> PostCour(Student d)
        {
            _context.AddStudent(d);
            return Ok(d);
        }

        [HttpGet]

        public ActionResult<ICollection<CourseController>> GetCour()
        {
            var res = _context.GetStudent();
            return Ok(res);
        }

        [HttpGet("{id}")]

        public ActionResult<ICollection<CourseController>> GetCour(int id)
        {
            var res = _context.GetStudent(id);
            return Ok(res);
        }

        [HttpDelete("{id}")]

        public void Delete(int id)
        {
            _context.DeleteStudent(id);
        }

        [HttpPut]

        public void Put(Student d)
        {
            _context.AddStudent(d);
        }
    }
}
