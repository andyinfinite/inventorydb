using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBRazor.Models
{
    public partial class ListLocation
    {
        [Display(Name ="Location Name")]
        public string LocationName { get; set; }
        
        [Key]
        [ForeignKey("TblMain")]
        public int LocationID { get; set; }
    }
}
