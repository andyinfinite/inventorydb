using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventoryDBRazor.Models
{
    public class InventoryDBContactContext : DbContext
    {
        public InventoryDBContactContext (DbContextOptions<InventoryDBContactContext> options)
            : base(options)
        {
        }

        public DbSet<InventoryDBRazor.Models.ListContact> ListContact { get; set; }
    }
}
