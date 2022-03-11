using ERP.Core.Domain.Common.Concrete;
using ERP.Core.Domain.Entities.Finance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Inventory
{
    public class ItemGroup : BaseEntity
    {
        public string ItemGroupCode { get; set; }
        public string ItemGroupName { get; set; }

        [DefaultValue(false)]
        public bool? ExcludeFromPurchase { get; set; } // Default = 0

        [DefaultValue(false)]
        public bool? ExcludeFromSales { get; set; } // Default = 0
        public long SalesAccountId { get; set; } // Account
        public long SalesDiscountAccountId { get; set; } // Account
        public long SalesReturnAccountId { get; set; } // Account
        public long PurchaseAccountId { get; set; } // Account
        public long PurchaseDiscountAccountId { get; set; } // Account
        public long InventoryReturnAccountId { get; set; } // Account
        public long CostOfGoodsSoldAccountId { get; set; } // Account
        public long? ParentItemGroupId { get; set; }  // ItemGroup

        [ForeignKey("SalesAccountId")]
        public virtual Account SalesAccount { get; set; }

        [ForeignKey("SalesDiscountAccountId")]
        public virtual Account SalesDiscountAccount { get; set; }

        [ForeignKey("SalesReturnAccountId")]
        public virtual Account SalesReturnAccount { get; set; }

        [ForeignKey("PurchaseAccountId")]
        public virtual Account PurchaseAccount { get; set; }

        [ForeignKey("PurchaseDiscountAccountId")]
        public virtual Account PurchaseDiscountAccount { get; set; }

        [ForeignKey("InventoryReturnAccountId")]
        public virtual Account InventoryReturnAccount { get; set; }

        [ForeignKey("CostOfGoodsSoldAccountId")]
        public virtual Account CostOfGoodsSoldAccount { get; set; }

        [ForeignKey("ParentItemGroupId")]
        public virtual ItemGroup ParentItemGroup { get; set; }
        public virtual ICollection<ItemGroup> ChildrenItemGroups { get; set; }
    }
}
