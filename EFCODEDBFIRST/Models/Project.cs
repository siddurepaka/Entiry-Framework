﻿using System;
using System.Collections.Generic;

namespace EFCODEDBFIRST.Models
{
    public partial class Project
    {
        public Project()
        {
            Employee = new HashSet<Employee>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Startdate { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
