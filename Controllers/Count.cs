using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAuthentication.Auth;
using ProjectAuthentication.Repository;
using System.Data;

namespace ProjectAuthentication.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class Count : ControllerBase
    {
        private readonly IStudentRepository _context;

        public Count(IStudentRepository context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public int GetCount(int id)
        {
            var res = _context.Results(id);

            return res;
        }
    }
}
