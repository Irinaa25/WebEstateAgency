﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Enties
{
    public class Realtor
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Phone { get; set; }
        public int Experience { get; set; }
        public virtual IEnumerable<Deal> Deals { get; set; } = new List<Deal>();
    }
}
