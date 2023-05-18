using System.ComponentModel.DataAnnotations;

namespace Nagarro.EventManagement.Shared
{
    public class UserDTO
    {
        [Required, EmailAddress]
        [Display(Name ="Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name ="Password")]
        [StringLength(20, MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string FullName { get; set; }
    }
}
