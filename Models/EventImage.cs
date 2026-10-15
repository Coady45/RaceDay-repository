using System;
using System.ComponentModel.DataAnnotations;

namespace Raceday_app.Models
{
    public class EventImage
    {
        public int ImageId { get; set; }

        public int EventId { get; set; }

        [Required]
        public string ImageUrl { get; set; } = "";

        public string? Caption { get; set; }

        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

        public Event? Event { get; set; }
    }
}