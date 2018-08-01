using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBRazor.Models
{
    public partial class ListVendor
    {
        [Key]
        [ForeignKey("ListVendorPOC")]
        public int vendorID { get; set; }

        [Display(Name = "Vendor Name")]
        public string vendorName { get; set; }

        [Display(Name = "Vendor Address 1")]
        public string vendorAddress1 { get; set; }

        [Display(Name = "Vendor Address 2")]
        public string vendorAddress2 { get; set; }

        [Display(Name = "Vendor City")]
        public string vendorCity { get; set; }

        [Display(Name = "Vendor State")]
        public string vendorState { get; set; }

        [Display(Name = "Vendor Zip")]
        public string vendorZip { get; set; }

        [Display(Name = "Vendor Phone")]
        public string vendorPhone { get; set; }

        [Display(Name = "Vendor URL")]
        public string vendorURL { get; set; }

    }
}
