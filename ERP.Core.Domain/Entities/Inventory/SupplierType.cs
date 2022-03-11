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
    public class SupplierType : BaseEntity
    {
        public string SupplierTypeCode { get; set; }
        public string SupplierTypeName { get; set; }
        public long AccountId { get; set; } // NOT NULL REFERENCES finance.accounts

        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }
    }
}
