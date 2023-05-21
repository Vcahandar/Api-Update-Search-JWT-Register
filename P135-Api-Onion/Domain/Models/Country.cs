﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<City> MyProperty { get; set; }
    }
}
