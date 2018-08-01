using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Design;
using InventoryDBRazor.Models;

namespace InventoryDBRazor.Models
{
    public partial class InventoryDBContext : DbContext
    {
        public InventoryDBContext()
        {
        }

        public InventoryDBContext(DbContextOptions<InventoryDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ListLocation> ListLocation { get; set; }
        public virtual DbSet<ListTools> ListTools { get; set; }
        public virtual DbSet<ListToolType> ListToolType { get; set; }
        public virtual DbSet<TblMain> TblMain { get; set; }
        public virtual DbSet<IPInfo> IPInfo { get; set; }
        public virtual DbSet<ListStatus> ListStatus { get; set; }
        public virtual DbSet<vwToolCount> vwToolCount { get; set; }
        public virtual DbSet<vwNoLicCount> vwNoLicCount { get; set; }
        public virtual DbSet<vwExpiredLicense> vwExpiredLicense { get; set; }
        //        public virtual DbSet<IntMainContact> IntMainContact { get; set; }
        //        public virtual DbSet<ListVendor> ListVendor { get; set; }
        //        public virtual DbSet<ListVendorPOC> ListVendorPOC { get; set; }
        //        public virtual DbSet<ListContact> ListContact { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
