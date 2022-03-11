using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Inventory
{
    public class CompoundUnit : BaseEntity
    {
        public long BaseUnitId { get; set; } // References Unit
        public int Value { get; set; } // DEFAULT(0) CHECk(value > 0)
        public long CompareUnitId { get; set; } // References Unit

        [ForeignKey("BaseUnitId")]
        public virtual Unit BaseUnit { get; set; }

        [ForeignKey("CompareUnitId")]
        public virtual Unit CompareUnit { get; set; }
    }
}
