using Authentication.Api.Base;

namespace Authentication.Api.Models
{
    public class RefreshToken :BaseEntity
    {

        public string Token { get; set; }
        public DateTime ExpiresOn { get; set; }
      
        public DateTime CreatedOn { get; set; }
        public DateTime? RevokedOn { get; set; }
      

    }
}
