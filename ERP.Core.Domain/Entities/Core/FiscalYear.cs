using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Core
{
    public class FiscalYear : BaseEntity
    {
        public string FiscalYearCode { get; set; }
        public string FiscalYearName { get; set; }
        public DateOnly StartsFrom { get; set; }
        public DateOnly EndsOn { get; set; }
        public virtual ICollection<FrequencySetup> FrequencySetups { get; set; }
    }
}
