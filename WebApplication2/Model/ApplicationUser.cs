using Microsoft.AspNetCore.Identity;

namespace WebApplication2.Model
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public string NumeroDocumento { get; set; } = string.Empty;
    }
}
