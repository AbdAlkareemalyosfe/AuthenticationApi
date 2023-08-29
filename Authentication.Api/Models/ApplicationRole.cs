using Authentication.Api.Base;
using Microsoft.AspNetCore.Identity;

namespace Authentication.Api.Models
{
    public class ApplicationRole :IdentityRole<Guid>
    {
     

        public ICollection<UserRole> RoleUsers { get; set; }

        public ApplicationRole()
        {
            RoleUsers = new HashSet<UserRole>();
        }

        public DateTime DateCreted { get; set; }
        public DateTime DateDeleteget{ set; get; }
        public DateTime DateLastUpdateget{set;get;}
    }
}
