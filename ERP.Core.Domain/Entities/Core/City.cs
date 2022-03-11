using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Core
{
    public class City : BaseEntity
    {
        public long StateId { get; set; } // NOT NULL REFERENCES core.states(state_id)
        public string CityName { get; set; }    // varying(100) NOT NULL

        [ForeignKey("StateId")]
        public virtual State State { get; set; }
    }
}
