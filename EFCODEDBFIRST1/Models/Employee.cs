﻿using System;
using System.Collections.Generic;

namespace EFCODEDBFIRST1.Models
{
    public partial class Employee
    {
        public string Eid { get; set; }
        public string Ename { get; set; }
        public DateTime Joindate { get; set; }
        public string Designation { get; set; }
        public decimal? Salry { get; set; }
        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }
    }
}
