using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Core
{
    public class State : BaseEntity
    {
        public long CountryId { get; set; } // NOT NULL REFERENCES core.countries(country_id)
        public string StateName { get; set; }    // varying(100) NOT NULL

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
