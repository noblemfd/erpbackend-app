using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Core
{
    public class Menu : BaseEntity
    {
        public string MenuCode { get; set; }    // varying(12) NOT NULL
        public string MenuName { get; set; }    // varying(50) UNIQUE NOT NULL
        public string MenuUrl { get; set; }    // varying(250) NULL
        public int? MenuLevel { get; set; } // Not Null
        public long? ParentMenuId { get; set; }  // References Same Model (Self Referencing)

        [ForeignKey("ParentMenuId")]
        public virtual Industry ParentMenu { get; set; }
    }
}
