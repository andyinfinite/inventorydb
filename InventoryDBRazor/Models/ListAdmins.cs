using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBRazor.Models
{
    public partial class ListAdmins
    {
        public string SUID { get; set; }

        [Key]
        public int userID { get; set; }


    }
}
