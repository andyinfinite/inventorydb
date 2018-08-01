using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventoryDBRazor.Models
{
    public class InventoryDBToolTypeContext : DbContext
    {
        public InventoryDBToolTypeContext (DbContextOptions<InventoryDBToolTypeContext> options)
            : base(options)
        {
        }

        public DbSet<InventoryDBRazor.Models.ListToolType> ListToolType { get; set; }
    }
}
