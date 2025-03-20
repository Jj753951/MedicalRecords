using Microsoft.AspNetCore.Identity;

namespace medicationred.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }  // Добави `?`, за да позволява NULL
        public string LastName { get; set; }   // Добави `?`, за да позволява NULL
    }

}
