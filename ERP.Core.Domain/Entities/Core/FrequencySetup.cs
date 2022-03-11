using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Core
{
    public class FrequencySetup : BaseEntity
    {
        public long FiscalYearId { get; set; }
        public string FrequencySetupCode { get; set; }  // Not Null
        public DateOnly ValueDate { get; set; } // Not Null Unique
        public long FrequencyId { get; set; }

        [ForeignKey("FiscalYearId")]
        public virtual FiscalYear FiscalYear { get; set; }

        [ForeignKey("FrequencyId")]
        public virtual Frequency Frequency { get; set; }
    }
}
