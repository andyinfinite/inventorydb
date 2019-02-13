using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBRazor.Models
{
    public class vwExpiredLicense
    {
        [Key]
        [Display(Name = "Tool Name")]
        public string ToolName { get; set; }

        [Display(Name = "Expired Licenses")]
        public int ExpLicCount { get; set; }

        public int ToolID { get; set; }

    }
}