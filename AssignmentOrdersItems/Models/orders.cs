using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AssignmentOrdersItems.Models
{
    [Table("Orders")]
  public   class Orders
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int ItemID { get; set; }
        [ForeignKey("ItemID")]
        public items items { get; set; }

    }
}
