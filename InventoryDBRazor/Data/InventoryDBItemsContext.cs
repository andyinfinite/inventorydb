using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventoryDBRazor.Models
{
    public class InventoryDBItemsContext : DbContext
    {
        public InventoryDBItemsContext (DbContextOptions<InventoryDBItemsContext> options)
            : base(options)
        {
        }

        public DbSet<InventoryDBRazor.Models.TblMain> TblMain { get; set; }
    }
}
