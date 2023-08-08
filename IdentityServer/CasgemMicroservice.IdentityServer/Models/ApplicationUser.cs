using Microsoft.AspNetCore.Identity;

namespace CasgemMicroservice.IdentityServer.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string NameSurname { get; set; }
        public string City { get; set; }
    }
}
