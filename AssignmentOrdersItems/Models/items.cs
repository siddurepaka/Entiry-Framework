using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace AssignmentOrdersItems.Models
{
    [Table("items")]
   public  class items
    {
        [Key]
        public int ItemId { get; set; }
        [Required]
        [StringLength(20)]
        public string ItemName { get; set; }
        public int? ItemPrice { get; set; }



    }
}
