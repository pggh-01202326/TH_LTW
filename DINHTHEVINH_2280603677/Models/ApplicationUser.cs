using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DINHTHEVINH_2280603677.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; }
        public string? Address { get; set; }
        public string? Age { get; set; }
    }
}
