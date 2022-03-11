using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Inventory
{
    public class Item : BaseEntity
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Barcode { get; set; } // Nullable and Unique
        public long ItemGroupId { get; set; }
        public long ItemTypeId { get; set; }
        public long BrandId { get; set; } // Nullable
        public long PreferredSupplierId { get; set; } // Nullable
        public int? LeadTimeInDays { get; set; }
        public long UnitId { get; set; }

        [DefaultValue(false)]
        public bool HotItem { get; set; } // Defualt = 0

        [DefaultValue(true)]
        public bool IsTaxableItem { get; set; } // Defualt = 1
        public decimal CostPrice { get; set; }

        [DefaultValue(false)]
        public bool CostPriceIncludeTax { get; set; } // Default = 0
        public decimal SellingPrice { get; set; }

        [DefaultValue(false)]
        public bool SellingPriceIncludeTax { get; set; } // Default = 0
        public int ReorderLevel { get; set; }
        public int ReorderQuantity { get; set; }
        public long ReorderUnitId { get; set; }

        [DefaultValue(true)]
        public bool MaintainInventory { get; set; } // Defualt = 1
        public string ImagePath { get; set; }

        [DefaultValue(true)]
        public bool AllowSales { get; set; } // Defualt = 1

        [DefaultValue(true)]
        public bool AllowPurchase { get; set; } // Defualt = 1

        public long? IsVariantOfId { get; set; }  // References Same Model (Self Referencing)

        [ForeignKey("IsVariantOfId")]
        public virtual Item IsVariantOf { get; set; }
        public virtual ICollection<Item> IsVariantOfs { get; set; }

        [ForeignKey("ItemGroupId")]
        public virtual ItemGroup ItemGroup { get; set; }

        [ForeignKey("ItemTypeId")]
        public virtual ItemType ItemType { get; set; }

        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }

        [ForeignKey("PreferredSupplierId")]
        public virtual Supplier PreferredSupplier { get; set; }

        [ForeignKey("UnitId")]
        public virtual Unit Unit { get; set; }

    }
}
