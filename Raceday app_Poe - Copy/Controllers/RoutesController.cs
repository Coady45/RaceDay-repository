using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Raceday_app.Data;
using Raceday_app.Models;

namespace Raceday_app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoutesController : ControllerBase
    {
        private readonly RaceDayContext _context;

        public RoutesController(RaceDayContext context)
        {
            _context = context;
        }

        // GET: api/routes
        [HttpGet]
        public async Task<IActionResult> GetRoutes()
        {
            var routes = await _context.Set<RouteInfo>().ToListAsync();

            return Ok(routes);
        }

        // GET: api/routes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoute(int id)
        {
            var route = await _context.Set<RouteInfo>().FindAsync(id);

            if (route == null)
                return NotFound("Route not found.");

            return Ok(route);
        }

        // POST: api/routes
        [HttpPost]
        public async Task<IActionResult> CreateRoute(RouteInfo route)
        {
            _context.Set<RouteInfo>().Add(route);

            await _context.SaveChangesAsync();

            return Ok(route);
        }

        // PUT: api/routes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRoute(int id, RouteInfo route)
        {
            var existingRoute = await _context.Set<RouteInfo>().FindAsync(id);

            if (existingRoute == null)
                return NotFound("Route not found.");

            _context.Entry(existingRoute).CurrentValues.SetValues(route);

            await _context.SaveChangesAsync();

            return Ok(existingRoute);
        }

        // DELETE: api/routes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoute(int id)
        {
            var route = await _context.Set<RouteInfo>().FindAsync(id);

            if (route == null)
                return NotFound("Route not found.");

            _context.Set<RouteInfo>().Remove(route);

            await _context.SaveChangesAsync();

            return Ok("Route deleted successfully.");
        }
    }
}
