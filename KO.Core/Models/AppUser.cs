using Microsoft.AspNetCore.Identity;

namespace KO.Core.Models
{
    public class AppUser : IdentityUser
    {
        public int AppRoleId { get; set; }
        public AppRole? AppRole { get; set; }

        public ICollection<BaseEntity>? UpdatedEntites { get; set; }
        public ICollection<BaseEntity>? CreatedEntites { get; set; }
    }
}
