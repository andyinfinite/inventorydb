using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBRazor.Models
{
    public partial class ListContact
    {
        [Display(Name = "POC Name")]
        public string Poc1_Name { get; set; }

        [Display(Name = "POC Email")]
        [DataType(DataType.EmailAddress)]
        public string Poc1_Email { get; set; }

        [Display(Name = "POC Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Poc1_Phone { get; set; }

        [Key]
        [ForeignKey("IntMainContact")]
        public int ContactId { get; set; }


    }
}
