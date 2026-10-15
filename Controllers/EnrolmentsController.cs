using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Raceday_app.Data;
using Raceday_app.Models;

namespace Raceday_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrolmentsController : ControllerBase
    {
        private readonly RaceDayContext _context;

        public EnrolmentsController(RaceDayContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetEnrolments()
        {
            return Ok(await _context.Enrolments.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Enrol([FromBody] Enrolment enrolment)
        {
            var role = HttpContext.Session.GetString("Role");
            if (role != "Participant") return Forbid();

            _context.Enrolments.Add(enrolment);
            await _context.SaveChangesAsync();
            return Ok(enrolment);
        }
    }
}
