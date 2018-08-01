using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryDBRazor.Models
{
    public partial class IPInfo
    {
        [Key]
        public int IPID { get; set; }

        [Display(Name = "Item ID")]
        public int itemID { get; set; }

        [Display(Name = "IP Address")]
        public string IPAddress { get; set; }

        [Display(Name = "Hostname")]
        public string hostname { get; set; }

        [Display(Name = "Netmask")]
        public string netmask { get; set; }

        [Display(Name = "Gateway")]
        public string gateway { get; set; }

        [Display(Name = "DNS 1")]
        public string DNS1 { get; set; }

        [Display(Name = "DNS 2")]
        public string DNS2 { get; set; }

        [Display(Name = "DNS 3")]
        public string DNS3 { get; set; }

        [Display(Name = "DNS Zone")]
        public string DNSZone { get; set; }
    }
}
