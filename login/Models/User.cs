using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace login.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required, EmailAddress ]
        public  string?  Email  { get; set; }

        [Required]
        public string? PasswordHash { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

