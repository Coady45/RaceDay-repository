using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Raceday_app.Models
{
    public class Event
    {
        public int EventId { get; set; }

        public int OrganiserId { get; set; }

        [Required]
        public string Title { get; set; } = "";

        public string? Description { get; set; }

        public DateTime EventDate { get; set; }

        [Required]
        public string Location { get; set; } = "";

        public string Status { get; set; } = "Upcoming";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public User? Organiser { get; set; }

        public ICollection<Category> Categories { get; set; }
            = new List<Category>();

        public RouteInfo? Route { get; set; }

        public ICollection<EventImage> Images { get; set; }
            = new List<EventImage>();
        public object Name { get; internal set; }
        public object Date { get; internal set; }
        public object Distance { get; internal set; }
        public object EventType { get; internal set; }
        public object Id { get; internal set; }
    }
}