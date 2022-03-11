using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Core
{
    public class Country : BaseEntity
    {
        public string StateCode { get; set; }    // varying(12) NOT NULL
        public string StateName { get; set; }    // varying(100) NOT NULL
        public string Nationality { get; set; } // varying(100) NOT NULL
        public virtual ICollection<State> States { get; set; }
    }
}
