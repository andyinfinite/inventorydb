using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBRazor.Models
{
    public partial class ListTools
    {
        [Display(Name ="Tool Name")]
        public string ToolName { get; set; }

        [Key]
        [ForeignKey("TblMain")]
        public int ToolId { get; set; }

    }
}
