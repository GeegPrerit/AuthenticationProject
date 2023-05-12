using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAuthentication.Auth;
using ProjectAuthentication.Models;
using ProjectAuthentication.Repository;
using System.Data;

namespace ProjectAuthentication.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _context;

        public CourseController(ICourseRepository context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult<ICollection<CourseController>> PostCour(Course d)
        {
            _context.AddCourse(d);
            return Ok(d);
        }

        [HttpGet]

        public async Task <ActionResult<IEnumerable<CourseController>>> GetCourse()
        {
            var res = _context.GetCourse();
            return Ok(res);
        }

        [HttpGet("{id}")]

        public ActionResult<ICollection<CourseController>> GetCourse(int id)
        {
            var res = _context.GetCourse(id);
            return Ok(res);
        }
        [HttpDelete("{id}")]

        public void Delete(int id)
        {
            _context.DeleteCourse(id);
        }
        [HttpPut]

        public void Put(Course d)
        {
            _context.AddCourse(d);
        }

        
    }
}
