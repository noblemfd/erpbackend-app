using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Finance
{
    public class AccountMaster : BaseEntity
    {
        public long OfficeId { get; set; }
        public string AccountMasterCode { get; set; }
        public string AccountMasterName { get; set; }
        public bool NormallyDebit { get; set; } // Default = 0
        public long ParentAccountMasterId { get; set; }

        [ForeignKey("ParentAccountMasterId")]
        public virtual AccountMaster ParentAccountMaster { get; set; }
        public virtual ICollection<AccountMaster> ChildrenAccountMaster { get; set; }
    }
}
