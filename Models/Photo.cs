﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mappers.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }
        public string Title { get; set; }
        public byte[] PhotoData { get; set; }
        public string MimeType { get; set; }
    }
}
