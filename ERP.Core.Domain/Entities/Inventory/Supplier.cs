using ERP.Core.Domain.Common.Concrete;
using ERP.Core.Domain.Entities.Finance;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Inventory
{
    public class Supplier : BaseEntity
    {
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string TaxNumber { get; set; }
        public long SupplierTypeId { get; set; }
        public long? AccountId { get; set; }  // References Account
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string LogoPath { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }

        [ForeignKey("SupplierTypeId")]
        public virtual SupplierType SupplierType { get; set; }
    }
}
