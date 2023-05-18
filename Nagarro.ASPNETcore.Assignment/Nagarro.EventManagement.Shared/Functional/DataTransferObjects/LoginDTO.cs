using System.ComponentModel.DataAnnotations;

namespace Nagarro.EventManagement.Shared
{
    public class LoginDTO
    {
        [Required, EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
