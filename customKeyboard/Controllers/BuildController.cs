using System; 
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using customKeyboard.Data;
using customKeyboard.Models;

namespace customKeyboard.Controllers
{
    [Route("/api/builds")]
    [ApiController]
    public class BuildController : ControllerBase
    {
        private readonly ApplicationDbContext _context; 
       
       public BuildController(ApplicationDbContext context)
       {
           _context = context; 
       }
        //@Route Post api/builds
        //@disc Create a build 
        //@auth registered
        [HttpPost]
        public IActionResult PostBuild([FromBody] Builds value)
        {
            _context.Builds.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        //@Route GET api/builds
        //@Disc Get all builds 
        //@auth registered 
        [HttpGet]
        public IActionResult GetAllBuilds()
        {
            var builds = _context.Builds;
            return Ok(builds);
        }
    }
} 