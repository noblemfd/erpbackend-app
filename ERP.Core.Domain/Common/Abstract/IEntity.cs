using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Common.Abstract
{
    public interface IEntity
    {
        public long Id { get; set; }
    }
}
