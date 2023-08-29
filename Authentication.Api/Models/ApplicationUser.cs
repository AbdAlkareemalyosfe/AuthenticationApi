using Authentication.Api.Base;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Authentication.Api.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
       

        #region BaseEntity 

    
        public DateTime DateCreted { get; set; }
        public DateTime DateDeleted { get; set; }
        public DateTime DateLastUpdated { get; set; }
        #endregion

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }
        public List<RefreshToken>? RefreshTokens { get; set; }
    }
}
