﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventoryDBRazor.Models
{
    public class InventoryDBLocationContext : DbContext
    {
        public InventoryDBLocationContext (DbContextOptions<InventoryDBLocationContext> options)
            : base(options)
        {
        }

        public DbSet<InventoryDBRazor.Models.ListLocation> ListLocation { get; set; }
    }
}
