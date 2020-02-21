﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mappers.Models
{
    public class State
    {
        public int StateID { get; set; }
        public string Name { get; set; }
        public ICollection<Base> Bases { get; set; }

    }
}
