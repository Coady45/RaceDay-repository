using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Raceday_app.Data;
using Raceday_app.Models;

namespace Raceday_app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventImagesController : ControllerBase
    {
        private readonly RaceDayContext _context;

        public EventImagesController(RaceDayContext context)
        {
            _context = context;
        }

        // GET: api/eventimages
        [HttpGet]
        public async Task<IActionResult> GetEventImages()
        {
            var images = await _context.Set<EventImage>().ToListAsync();

            return Ok(images);
        }

        // GET: api/eventimages/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEventImage(int id)
        {
            var image = await _context.Set<EventImage>().FindAsync(id);

            if (image == null)
                return NotFound("Event image not found.");

            return Ok(image);
        }

        // POST: api/eventimages
        [HttpPost]
        public async Task<IActionResult> CreateEventImage(EventImage image)
        {
            _context.Set<EventImage>().Add(image);

            await _context.SaveChangesAsync();

            return Ok(image);
        }

        // PUT: api/eventimages/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEventImage(int id, EventImage image)
        {
            var existingImage = await _context.Set<EventImage>().FindAsync(id);

            if (existingImage == null)
                return NotFound("Event image not found.");

            _context.Entry(existingImage).CurrentValues.SetValues(image);

            await _context.SaveChangesAsync();

            return Ok(existingImage);
        }

        // DELETE: api/eventimages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventImage(int id)
        {
            var image = await _context.Set<EventImage>().FindAsync(id);

            if (image == null)
                return NotFound("Event image not found.");

            _context.Set<EventImage>().Remove(image);

            await _context.SaveChangesAsync();

            return Ok("Event image deleted successfully.");
        }
    }
}