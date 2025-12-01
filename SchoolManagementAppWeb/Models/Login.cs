using System.ComponentModel.DataAnnotations;

namespace SchoolManagementAppWeb.Models
{
    public class Login
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        public string? ReturnUrl { get; set; }
    }
}

