using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Inventory
{
    public class Unit : BaseEntity
    {
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public virtual ICollection<CompoundUnit> BaseUnits { get; set; }
        public virtual ICollection<CompoundUnit> CompareUnits { get; set; }
    }
}
