using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Core
{
    public class Currency : BaseEntity
    {
        public string CurrencyCode { get; set; }    // varying(12) NOT NULL
        public string CurrencySymbol { get; set; }    // varying(12) NOT NULL
        public string CurrencyName { get; set; }    // varying(50) UNIQUE NOT NULL
        public string HundredthName { get; set; }    // varying(50) NOT NULL
    }
}
