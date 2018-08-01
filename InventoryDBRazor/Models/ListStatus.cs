using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBRazor.Models
{
    public partial class ListStatus
    {
        [Display(Name = "Status")]
        public string Status { get; set; }

        [Key]
        [ForeignKey("TblMain")]
        public int StatusID { get; set; }


    }
}
