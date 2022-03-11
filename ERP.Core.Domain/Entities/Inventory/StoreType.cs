using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Inventory
{
    public class StoreType : BaseEntity
    {
        public string StoreTypeCode { get; set; }
        public string StoreTypeName { get; set; }

        public virtual ICollection<Store> Store { get; set; }
    }
}
