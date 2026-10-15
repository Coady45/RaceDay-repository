using System;
using System.ComponentModel.DataAnnotations;

namespace Raceday_app.Models
{
    public class Enrolment
    {
        public int EnrolmentId { get; set; }

        public int ParticipantId { get; set; }

        public int CategoryId { get; set; }

        public DateTime EnrolmentDate { get; set; } = DateTime.UtcNow;

        public string Status { get; set; } = "Registered";

        public User? Participant { get; set; }

        public Category? Category { get; set; }

        public Result? Result { get; set; }
    }
}
