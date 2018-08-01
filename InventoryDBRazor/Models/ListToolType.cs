using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBRazor.Models
{
    public partial class ListToolType
    {
        [Display(Name = "Tool Type")]
        public string ToolType { get; set; }

        [Key]
        [ForeignKey("TblMain")]
        public int TypeId { get; set; }
    }
}
