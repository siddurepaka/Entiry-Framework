﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFDAL.Models
{
    [Table ("Employee")]
    public class Employee
    {
        [Key]
        [StringLength(5)]
        public string Eid { get; set; }
        [Required]
       
        [StringLength(30)]
        public string Ename { get; set; }
        [Column(TypeName ="Date")]
        public DateTime joindate { get; set; }
        [StringLength(20)]
        public string Designation { get; set; }
        public decimal? Salry { get; set; }
        public int ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project project { get; set; }
    }
}
