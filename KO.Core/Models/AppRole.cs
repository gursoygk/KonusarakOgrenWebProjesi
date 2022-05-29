using Microsoft.AspNetCore.Identity;

namespace KO.Core.Models
{
    public class AppRole : IdentityRole
    {
        public ICollection<AppUser>? AppUsers { get; set; }
    }
}
