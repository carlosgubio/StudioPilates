using Microsoft.AspNetCore.Identity;

namespace StudioPilates.Models
{
    //Mostrar o nome do cliente na página
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
