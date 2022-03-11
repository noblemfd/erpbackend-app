using Microsoft.AspNetCore.Identity;

namespace ERP.Core.Domain.Entities.IdentityModels
{
    public class ApplicationRole : IdentityRole<long>
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
