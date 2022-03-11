using ERP.Core.Domain.DTOs.Auth;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace ERP.Core.Domain.Entities.IdentityModels
{
    public class ApplicationUser : IdentityUser<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }

        [JsonIgnore]
        public bool? IsPasswordChanged { get; set; }

        [JsonIgnore]
        public bool? IsDeleted { get; set; }
        public DateTime? LastLogin { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; }
        public bool OwnsToken(string token)
        {
            return this.RefreshTokens?.Find(x => x.Token == token) != null;
        }
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
