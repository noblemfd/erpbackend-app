using ERP.Core.Domain.Common.Concrete;
using ERP.Core.Domain.Entities.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Finance
{
    public class CashRepository : BaseEntity
    {
        public long OfficeId { get; set; }
        public string CashRepositoryCode { get; set; }
        public string CashRepositoryName { get; set; }
        public long ParentCashRepositoryId { get; set; }
        public string Description   { get; set; }

        [ForeignKey("OfficeId")]
        public virtual Office Office { get; set; }

        [ForeignKey("ParentCashRepositoryId")]
        public virtual CashRepository ParentCashRepository { get; set; }
        public virtual ICollection<CashRepository> ChildrenCashRepositories { get; set; }
    }
}
