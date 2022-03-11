using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Inventory
{
    public class Brand : BaseEntity
    {
        public string BrandCode { get; set; }
        public string BrandName { get; set; }
    }
}
