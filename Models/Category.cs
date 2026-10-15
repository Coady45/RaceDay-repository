using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Raceday_app.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public int EventId { get; set; }

        [Required]
        public string Name { get; set; } = "";

        public decimal DistanceKm { get; set; }

        public int? MaxParticipants { get; set; }

        public Event? Event { get; set; }

        public ICollection<Enrolment> Enrolments { get; set; }
            = new List<Enrolment>();
    }
}