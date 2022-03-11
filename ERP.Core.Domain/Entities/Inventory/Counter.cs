using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Finance
{
    public class Counter : BaseEntity
    {
        public string CounterCode { get; set; }
        public string CounterName { get; set; }
        public long StoreId { get; set; }

        [ForeignKey("OfficeId")]
        public virtual Office Office { get; set; }
    }
}
