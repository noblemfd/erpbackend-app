using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Core
{
    public class Frequency : BaseEntity
    {
        public string FrequencyCode { get; set; }
        public string FrequencyName { get; set; }
        public virtual ICollection<FrequencySetup> FrequencySetups { get; set; }
    }
}
