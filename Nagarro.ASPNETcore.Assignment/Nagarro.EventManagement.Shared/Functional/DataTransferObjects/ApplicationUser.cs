using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Nagarro.EventManagement.Shared

{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; }
    }
}
