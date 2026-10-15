using System;
using System.ComponentModel.DataAnnotations;

namespace Raceday_app.Models
{
    public class Result
    {
        public int ResultId { get; set; }

        public int EnrolmentId { get; set; }

        public TimeSpan? FinishTime { get; set; }

        public int? Position { get; set; }

        public string? Notes { get; set; }

        public DateTime RecordedAt { get; set; } = DateTime.UtcNow;

        public Enrolment? Enrolment { get; set; }
    }
}
