using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Core
{
    public class Office : BaseEntity
    {
        public string OfficeCode { get; set; }
        public string OfficeName { get; set; }
        public string NickName { get; set; }
        public DateOnly RegistrationDate { get; set; }
        public string PoBox { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long CountryId { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public string LogoPath { get; set; }
        public string RegistrationNumber { get; set; }
        public long ParentOfficeId { get; set; }

        [DefaultValue(false)]
        public bool? AllowTransactionPosting { get; set; } // Default = 0

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        [ForeignKey("ParentOfficeId")]
        public virtual Office ParentOffice { get; set; }
        public virtual ICollection<Office> BranchOffices { get; set; }
    }
}
