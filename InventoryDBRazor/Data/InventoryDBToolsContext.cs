﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventoryDBRazor.Models
{
    public class InventoryDBToolsContext : DbContext
    {
        public InventoryDBToolsContext (DbContextOptions<InventoryDBToolsContext> options)
            : base(options)
        {
        }

        public DbSet<InventoryDBRazor.Models.ListTools> ListTools { get; set; }
    }
}
