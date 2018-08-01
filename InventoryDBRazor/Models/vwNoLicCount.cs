using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryDBRazor.Models
{
    public partial class vwNoLicCount
    {
        [Key]
        [Display(Name = "Tool Name")]
        public string ToolName { get; set; }

        [Display(Name = "Not Licensed")]
        public int NoLicCount { get; set; }

        public int ToolID { get; set; }

    }
}