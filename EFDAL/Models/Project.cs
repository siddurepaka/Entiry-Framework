using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFDAL.Models
{
    [Table("Project")]
    
   public class Project
    { [Key]
        public int projectID { get; set; }
        [Required]
        [StringLength(30)]
        public string ProjectName { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
    }
}
