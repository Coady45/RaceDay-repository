using System;
using System.ComponentModel.DataAnnotations;

namespace Raceday_app.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string Email { get; set; } = "";

        [Required]
        public string PasswordHash { get; set; } = "";

        [Required]
        public string FirstName { get; set; } = "";

        [Required]
        public string LastName { get; set; } = "";

        [Required]
        public string Role { get; set; } = "Participant";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public object FullName { get; internal set; }
        public string Password { get; internal set; }
        public object Id { get; internal set; }
    }
}