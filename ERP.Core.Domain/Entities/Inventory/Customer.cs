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
    public class Customer : BaseEntity
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string TaxNumber { get; set; }
        public long CustomerTypeId { get; set; }
        public long? AccountId { get; set; }  // References Account
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string LogoPath { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }

        [ForeignKey("CustomerTypeId")]
        public virtual CustomerType CustomerType { get; set; }
    }
}
