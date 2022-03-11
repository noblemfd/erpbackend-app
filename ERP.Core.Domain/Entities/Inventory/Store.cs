using ERP.Core.Domain.Common.Concrete;
using ERP.Core.Domain.Entities.Core;
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
    public class Store : BaseEntity
    {
        public string StoreCode { get; set; }
        public string StoreName { get; set; }
        public long StoreTypeId { get; set; }
        public long OfficeId { get; set; }
        public long DefaultAccountIdForChecks { get; set; } // Account
        public long DefaultCashAccountId { get; set; } // Account
        public long DefaultCashRepositoryId { get; set; } // Cash Repository
        public string AddressLine1 { get; set; } // Nullable
        public string AddressLine2 { get; set; } // Nullable
        public string City { get; set; } // Nullable
        public string State { get; set; } // Nullable
        public long CountryId { get; set; } // Nullable
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

        [DefaultValue(true)]
        public bool AllowSales { get; set; } // Defualt = 1
        public long SalesDiscountAccountId { get; set; } // accounts DEFAULT(finance.get_account_id_by_account_number('40270')),
        public long PurchaseDiscountAccountId { get; set; } // accounts DEFAULT(finance.get_account_id_by_account_number('30700'))
        public long ShippingExpenseAccountId { get; set; } // accounts DEFAULT(finance.get_account_id_by_account_number('43000'))

        [ForeignKey("StoreTypeId")]
        public virtual StoreType StoreType { get; set; }

        [ForeignKey("OfficeId")]
        public virtual Office Office { get; set; }

        [ForeignKey("DefaultAccountIdForChecks")]
        public virtual Account DefaultAccountIdForCheck { get; set; }

        [ForeignKey("DefaultCashAccountId")]
        public virtual Account DefaultCashAccount { get; set; }

        [ForeignKey("DefaultCashRepositoryId")]
        public virtual CashRepository DefaultCashRepository { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
    }
}
