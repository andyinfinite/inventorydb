using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace InventoryDBRazor.Models
{
    public partial class vwSearch
    {
        [Key]
        [Display(Name = "Item ID")]
        public int ItemId { get; set; }

        [Display(Name = "IP Address")]
        public string IPAddress { get; set; }

        [Display(Name = "Item Name")]
        public string ItemName { get; set; }

        [Display(Name = "Item Description")]
        public string ItemDescription { get; set; }

        [Display(Name = "Item Ownership")]
        public string ItemOwnership { get; set; }

        [Display(Name = "Tool Type")]
        public string ToolType { get; set; }

        [Display(Name = "Tool Name")]
        public string ToolName { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }

        [Display(Name = "Location Name")]
        public string LocationName { get; set; }

        [Display(Name = "Host Name")]
        public string hostname { get; set; }

        [Display(Name = "Gateway")]
        public string gateway { get; set; }

        [Display(Name = "Netmask")]
        public string netmask { get; set; }

        [Display(Name = "DNS 1")]
        public string DNS1 { get; set; }

        [Display(Name = "DNS 2")]
        public string DNS2 { get; set; }

        [Display(Name = "DNS 3")]
        public string DNS3 { get; set; }

        [Display(Name = "Additional Info")]
        public string AdditionalInfo { get; set; }

        [Display(Name = "Vendor")]
        public string Vendor { get; set; }

        [Display(Name = "Model Number")]
        public string ModelNumber { get; set; }

        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }

        [Display(Name = "Serial Number 2")]
        public string SerialNumber2 { get; set; }

        [Display(Name = "State Asset Tag")]
        public string StateAssetTag { get; set; }

        [Display(Name = "Installed Location")]
        public string InstalledLocation { get; set; }

        [Display(Name = "Installed Location 2")]
        public string InstalledLocation2 { get; set; }

        [Display(Name = "Storage Location")]
        public string StorageLocation { get; set; }

        [Display(Name = "License Part Number")]
        public string LicensePartNumber { get; set; }

        [Display(Name = "License Method")]
        public string LicenseMethod { get; set; }

        [Display(Name = "Vendor Order Reference Number")]
        public string VendorOrderRefNum { get; set; }

        [Display(Name = "Vendor Customer Number")]
        public string VendorCustomerNum { get; set; }

        [Display(Name = "Vendor Site Number")]
        public string VendorSiteNum { get; set; }

        [Display(Name = "Internal Billing Code")]
        public string InternalBillingCode { get; set; }

        [Display(Name = "Purchase Order")]
        public string PurchaseOrder { get; set; }

        [Display(Name = "Request For Quote")]
        public string RequestForQuote { get; set; }

        [Display(Name = "Selected Quote")]
        public string SelectedQuote { get; set; }

        [Display(Name = "Agency Purchase Request")]
        public string AgencyPurchaseRequest { get; set; }

        [Display(Name = "VM OS")]
        public string VM_OS { get; set; }

        [Display(Name = "VM CPUs")]
        public string VM_CPU { get; set; }

        [Display(Name = "VM RAM")]
        public string VM_RAM { get; set; }

        [Display(Name = "Software Version")]
        public string SoftwareVersion { get; set; }

        [Display(Name = "Firmware Version")]
        public string FirmwareVersion { get; set; }

        [Display(Name = "Product Key")]
        public string ProductKey { get; set; }

        [Display(Name = "End Of Life")]
        [DataType(DataType.Date)]
        public DateTime? EOLDate { get; set; }

        [Display(Name = "End Of Service")]
        [DataType(DataType.Date)]
        public DateTime? EOSDate { get; set; }

        [Display(Name = "License Status")]
        public string LicenseStatus { get; set; }

        [Display(Name = "License Quantity")]
        public string LicenseQuantity { get; set; }

        [Display(Name = "License Expiration")]
        [DataType(DataType.Date)]
        public DateTime? LicenseExpiration { get; set; }

        [Display(Name = "License Frequency")]
        public string LicenseFrequency { get; set; }

        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }

        [Display(Name = "Purchase Cost")]
        [DataType(DataType.Currency)]
        public int? PurchaseCost { get; set; }

        [Display(Name = "Support Cost")]
        [DataType(DataType.Currency)]
        public int? SupportCost { get; set; }

        [Display(Name = "Manufacturer")]
        public string Manufacturer { get; set; }
        
    }
}
