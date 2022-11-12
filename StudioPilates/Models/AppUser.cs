

using Microsoft.AspNetCore.Identity;

namespace StudioPilates.Models
{
    public class AppUser: IdentityUser
    {
        public string Name { get; set; }
    }
}
