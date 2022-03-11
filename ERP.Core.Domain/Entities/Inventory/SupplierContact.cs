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
    public class SupplierContact : BaseEntity
    {
        public long SupplierId { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long CountryId { get; set; }
        public string PhoneLine1 { get; set; }
        public string PhoneLine2 { get; set; }
        public string PhotoPath { get; set; }
        public DateTime ChangedDate { get; set; }

        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
    }
}
