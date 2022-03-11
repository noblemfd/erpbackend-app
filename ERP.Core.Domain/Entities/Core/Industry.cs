using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Core
{
    public class Industry : BaseEntity
    {
        public string IndustryNme { get; set; }
        public long? ParentIndustryId { get; set; }  // References Same Model (Self Referencing)
        
        [ForeignKey("ParentIndustryId")]
        public virtual Industry ParentIndustry { get; set; }
    }
}
