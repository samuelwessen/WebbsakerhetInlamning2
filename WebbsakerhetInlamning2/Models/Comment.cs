﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbsakerhetInlamning2.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Content { get; set; }
    }
}
