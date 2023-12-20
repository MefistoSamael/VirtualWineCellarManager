﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Collection
    {
        public int Id {  get; set; }

        public string Note { get; set; }

        public DateTime Date { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
