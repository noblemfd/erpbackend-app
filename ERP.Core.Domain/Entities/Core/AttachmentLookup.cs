﻿using ERP.Core.Domain.Common.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domain.Entities.Core
{
    public class AttachmentLookup : BaseEntity
    {
        public string Book { get; set; }    // varying(50) NOT NULL
    }
}
