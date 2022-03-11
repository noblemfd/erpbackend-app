using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Inventory
{
    public class CustomerPhone : BaseEntity
    {
        public long CustomerId { get; set; }
        public long PhoneNumberTypeId { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public DateTime ChangeDate { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("PhoneNumberTypeId")]
        public virtual PhoneNumberType PhoneNumberType { get; set; }
    }
}
