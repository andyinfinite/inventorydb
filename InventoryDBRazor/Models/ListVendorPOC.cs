using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBRazor.Models
{
    public partial class ListVendorPOC
    {
        [Key]
        [ForeignKey("TblMain")]
        public int vendorPOCID { get; set; }

        [Display(Name = "Vendor POC First Name")]
        public string vendorPOCFirstName { get; set; }

        [Display(Name = "Vendor POC Last Name")]
        public string vendorPOCLastName { get; set; }

        [Display(Name = "Vendor POC Name")]
        public string FullName
        {
            get
            {
                return vendorPOCFirstName + " " + vendorPOCLastName;
            }
        }

        [Display(Name = "Vendor POC Title")]
        public string vendorPOCTitle { get; set; }

        [Display(Name = "Vendor POC Email")]
        public string vendorPOCEmail { get; set; }

        [Display(Name = "Vendor POC Phone Office")]
        public string vendorPOCPhoneOffice { get; set; }

        [Display(Name = "Vendor POC Phone Cell")]
        public string vendorPOCPhoneCell { get; set; }

        [ForeignKey("ListVendor")]
        public int vendorID { get; set; }
        
    }
}
