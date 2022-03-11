using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Inventory
{
    public class ItemType : BaseEntity
    {
        public string ItemTypeCode { get; set; }
        public string ItemTypeName { get; set; }

        [DefaultValue(false)]
        public bool IsComponent { get; set; } // Default = 0
    }
}
