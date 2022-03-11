using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Core
{
    public class PriceType : BaseEntity
    {
        public string PriceTypeCode { get; set; }    // varying(12) NOT NULL
        public string PriceTypeName { get; set; }    // varying(50) UNIQUE NOT NULL
    }
}
