using System.ComponentModel.DataAnnotations;

namespace Raceday_app.Models
{
    public class RouteInfo
    {
        public int RouteId { get; set; }

        public int EventId { get; set; }

        public string? Description { get; set; }

        public string? MapUrl { get; set; }

        public decimal? TotalDistanceKm { get; set; }

        public Event? Event { get; set; }
    }
}