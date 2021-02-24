using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    //DTOs are data transfer objects. works bridge between front/backend
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}