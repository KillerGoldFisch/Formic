﻿using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formic.Models
{
    public class RecordSet
    {
        public PropertySchema[] Properties { get; set; }
        public object[] Data { get; set; }
    }

    public class PropertySchema
    {
        public string Description { get; set; }
        public IPropertyBase Property { get; set; }
    }
}
