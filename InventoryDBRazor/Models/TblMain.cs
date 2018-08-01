using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBRazor.Models
{
    public partial class TblMain
    {
        [Display(Name ="Item Name")]
        public string ItemName { get; set; }

        [Display(Name ="Item Description")]
        public string ItemDescription { get; set; }

        [Display(Name ="Item Owner")]
        public string ItemOwnership { get; set; }

        [Display(Name ="Additional Info")]
        public string AdditionalInfo { get; set; }

        [Display(Name ="Vendor")]
        public string Vendor { get; set; }

        [Display(Name ="Model Number")]
        public string ModelNumber { get; set; }

        [Display(Name ="Firmware Version")]
        public string FirmwareVersion { get; set; }

        [Display(Name ="Software Version")]
        public string SoftwareVersion { get; set; }

        [Display(Name ="Serial Number")]
        public string SerialNumber { get; set; }

        [Display(Name ="Serial Number 2")]
        public string SerialNumber2 { get; set; }

        [Display(Name ="State Asset Tag")]
        public string StateAssetTag { get; set; }

        [Display(Name ="Product Key")]
        public string ProductKey { get; set; }

        [Display(Name ="End of Life")]
        [DataType(DataType.Date)]
        public DateTime? Eoldate { get; set; }

        [Display(Name ="End Of Service")]
        [DataType(DataType.Date)]
        public DateTime? Eosdate { get; set; }

        [Display(Name ="Manufacturer")]
        public string Manufacturer { get; set; }

        [Display(Name ="GeoLocation")]
        [ForeignKey("ListLocation")]
        public int? GeoLocation { get; set; }

        [Display(Name ="Installed Location")]
        public string InstalledLocation { get; set; }

        [Display(Name ="Installed Location 2")]
        public string InstalledLocation2 { get; set; }

        [Display(Name ="Storage Location")]
        public string StorageLocation { get; set; }

        [Display(Name ="Status")]
        [ForeignKey("ListStatus")]
        public int? ItemStatus { get; set; }

        [Display(Name ="Item Type")]
        [ForeignKey("ListToolType")]
        public int? ItemType { get; set; }

        [Display(Name ="Tool Name")]
        [ForeignKey("ListTools")]
        public int? ToolName { get; set; }

        [Display(Name ="VM RAM")]
        public string Vm_Ram { get; set; }

        [Display(Name ="VM CPUs")]
        public string Vm_Cpu { get; set; }

        [Display(Name ="VM OS")]
        public string Vm_Os { get; set; }

        [Display(Name ="License Status")]
        public string LicenseStatus { get; set; }

        [Display(Name ="License Method")]
        public string LicenseMethod { get; set; }

        [Display(Name ="License Quantity")]
        public string LicenseQuantity { get; set; }

        [Display(Name ="License Expiration")]
        [DataType(DataType.Date)]
        public DateTime? LicenseExpiration { get; set; }

        [Display(Name ="License Frequency")]
        public string LicenseFrequency { get; set; }

        [Display(Name ="License Part Number")]
        public string LicensePartNumber { get; set; }

        [Display(Name ="Vendor Order Reference Number")]
        public string VendorOrderRefNum { get; set; }

        [Display(Name ="Vendor Customer Number")]
        public string VendorCustomerNum { get; set; }

        [Display(Name ="Vendor Site Number")]
        public string VendorSiteNum { get; set; }

        [Display(Name ="Order Date")]
        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }

        [Display(Name ="Internal Billing Number")]
        public string InternalBillingCode { get; set; }

        [Display(Name ="OISP Invoice Number")]
        public string OispinvoiceNum { get; set; }

        [Display(Name ="Purchase Cost")]
        [DataType(DataType.Currency)]
        public int? PurchaseCost { get; set; }

        [Display(Name ="Annual Cost")]
        [DataType(DataType.Currency)]
        public int? AnnualCost { get; set; }

        [Display(Name ="Monthly Cost")]
        [DataType(DataType.Currency)]
        public int? MonthlyCost { get; set; }

        [Key]
        public int ItemId { get; set; }

        public ListLocation ListLocation { get; set; }
        public ListTools ListTools { get; set; }
        public ListToolType ListToolType { get; set; }
        public ListStatus ListStatus { get; set; }
        public IPInfo IPInfo { get; set; }

    }
}
