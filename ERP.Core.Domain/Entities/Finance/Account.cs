using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Finance
{
    public class Account : BaseEntity
    {
        public long AccountMasterId { get; set; }
        public string AccountNumber { get; set; }
        public string ExternalCode { get; set; } // Null
        public string AccountName { get; set; }
        public string Description { get; set; } // Null
        public bool IsConfidential { get; set; } // Default = 0
        public bool IsTransactionNode { get; set; } // Default = 1
        public bool SystemType { get; set; } // Defsult = 0
        public long ParentAccountId { get; set; }

        [ForeignKey("AccountMasterId")]
        public virtual AccountMaster AccountMaster { get; set; }

        [ForeignKey("ParentOfficeId")]
        public virtual Account ParentAccount { get; set; }
        public virtual ICollection<Account> ChildrenAccounts { get; set; }
    }
}
