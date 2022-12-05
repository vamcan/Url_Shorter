﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlShorter.Domain.Common;

namespace UrlShorter.Domain.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public DateTime RecordDate { get; set; }
    }
}