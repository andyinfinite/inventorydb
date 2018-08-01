using System.ComponentModel.DataAnnotations;

namespace InventoryDBRazor.Models
{
    public class vwToolCount
    {
        [Key]
        [Display(Name = "Tool Name")]
        public string ToolName { get; set; }

        [Display(Name = "Tool Count")]
        public int ToolCount { get; set; }

        public int ToolID { get; set; }
    }
}