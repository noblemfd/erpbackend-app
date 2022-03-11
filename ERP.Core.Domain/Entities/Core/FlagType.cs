using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Core
{
    public class FlagType : BaseEntity
    {
        public string FlagTypeName { get; set; }  //national character varying(24) NOT NULL,
        public string BackgroundColour { get; set; }   //NOT NULL,
        public string ForegroundColour { get; set; }   // NOT NULL,
        public virtual ICollection<Flag> Flags { get; set; }
    }
}
