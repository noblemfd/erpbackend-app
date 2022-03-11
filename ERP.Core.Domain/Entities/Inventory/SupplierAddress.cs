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
    public class SupplierAddress : BaseEntity
    {
        public long SupplierId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long CountryId { get; set; }
        public DateTime ChangedDate { get; set; }
        public string PoBox { get; set; }

        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
    }
}
