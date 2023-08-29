using Authentication.Api.Base;

namespace Authentication.Api.Models
{
    public class UserRole :BaseEntity
    {
        public UserRole()
        {
        }

        public Guid UserId { get; set; }
       public Guid RoleId { get; set; }
        public ApplicationUser User { get; set; }
        public ApplicationRole Role { get; set; }
    }
}
