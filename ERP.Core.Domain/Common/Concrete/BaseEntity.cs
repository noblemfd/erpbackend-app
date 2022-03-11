using ERP.Core.Domain.Common.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Common.Concrete
{
    public class BaseEntity : IEntity, ISoftDeletable, IAudited
    {
        [Key]
        public long Id { get; set; }
        public string CreatedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreatedAt { get; set; }

        public string LastModifiedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? LastModifiedAt { get; set; }

        [JsonIgnore]
        public bool? IsDeleted { get; set; }
        public string DeletedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DeletedAt { get; set; }
    }
}
