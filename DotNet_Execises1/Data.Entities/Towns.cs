﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Towns
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int CountryId { get; set; }
        public Countries Countries { get; set; }
    }
}
