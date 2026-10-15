using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Raceday_app.Data;
using Raceday_app.Models;

namespace Raceday_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultsController : ControllerBase
    {
        private readonly RaceDayContext _context;

        public ResultsController(RaceDayContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetResults()
        {
            return Ok(await _context.Results.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddResult([FromBody] Result result)
        {
            var role = HttpContext.Session.GetString("Role");
            if (role != "Organiser") return Forbid();

            _context.Results.Add(result);
            await _context.SaveChangesAsync();
            return Ok(result);
        }
    }
}
