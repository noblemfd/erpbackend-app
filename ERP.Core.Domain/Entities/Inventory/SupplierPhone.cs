using ERP.Core.Domain.Common.Concrete;
using ERP.Core.Domain.Entities.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Inventory
{
    public class SupplierPhone : BaseEntity
    {
        public long SupplierId { get; set; }
        public long PhoneNumberTypeId { get; set; }
        public string SupplierPhoneNumber { get; set; }
        public DateTime ChangeDate { get; set; }

        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }

        [ForeignKey("PhoneNumberTypeId")]
        public virtual PhoneNumberType PhoneNumberType { get; set; }
    }
}
