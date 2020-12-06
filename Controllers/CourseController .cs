using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPNET5Demo.Models;

namespace ASPNET5Demo.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CourseController :ControllerBase
    {
           private readonly ContosoUniversityContext _context;

        public CourseController(ContosoUniversityContext context)
        {
            _context = context;
        }

        // GET: api/Course
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourse()
        {
            return await _context.Courses.ToListAsync();
        }
    }
}