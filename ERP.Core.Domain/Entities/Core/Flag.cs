using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Core
{
    public class Flag : BaseEntity
    {
        public long FlagTypeId { get; set; }    // integer NOT NULL REFERENCES core.flag_types(id)
        public string Resource { get; set; }    // text, --Fully qualified resource name. Example: transactions.non_gl_stock_master
        public string ResourceKey { get; set; } // text, --The unique identifier for lookup. Example: non_gl_stock_master_id
        public string ResourceId { get; set; }  // text, --The value of the unique identifier to lookup for
        public DateTime? FlaggedOn { get; set; } // TIMESTAMP WITH TIME ZONE NULL DEFAULT(NOW())

        [ForeignKey("FlagTypeId")]
        public virtual FlagType FlagType { get; set; }
    }
}
