using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBRazor.Models
{
    public partial class IntMainContact
    {
        [Key]
        public int CID { get; set; }

        [Display(Name = "Item ID")]
        public int ItemID { get; set; }

        [Display(Name = "Is Primary")]
        public int isPrimary { get; set; }

        [Display(Name = "Contact ID")]
        public int ContactID { get; set; }

        public virtual ListContact ListContact { get; set; }
    }
}
