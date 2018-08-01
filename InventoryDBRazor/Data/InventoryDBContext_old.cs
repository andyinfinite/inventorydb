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

        public virtual DbSet<ListContact> ListContact { get; set; }
        public virtual DbSet<ListLocation> ListLocation { get; set; }
        public virtual DbSet<ListTools> ListTools { get; set; }
        public virtual DbSet<ListToolType> ListToolType { get; set; }
        public virtual DbSet<TblMain> TblMain { get; set; }
        public virtual DbSet<ListVendor> ListVendor { get; set; }
        public virtual DbSet<ListVendorPOC> ListVendorPOC { get; set; }
        public virtual DbSet<IPInfo> IPInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=dassocipstsp01;Initial Catalog=InventoryDB;Integrated Security=True;User Id=inventory;Password=Wsaba2r.tssfnmdb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListContact>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("listContact");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.Poc1_Email)
                    .HasColumnName("POC1_Email")
                    .HasMaxLength(255);

                entity.Property(e => e.Poc1_Name)
                    .HasColumnName("POC1_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Poc1_Phone)
                    .HasColumnName("POC1_Phone")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ListLocation>(entity =>
            {
                entity.HasKey(e => e.LocationID);

                entity.ToTable("listLocation");

                entity.Property(e => e.LocationID).HasColumnName("LocationID");

                entity.Property(e => e.LocationName).HasMaxLength(255);
            });

            modelBuilder.Entity<ListTools>(entity =>
            {
                entity.HasKey(e => e.ToolId);

                entity.ToTable("listTools");

                entity.Property(e => e.ToolId).HasColumnName("ToolID");

                entity.Property(e => e.ToolName).HasMaxLength(255);
            });

            modelBuilder.Entity<ListToolType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("listToolType");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.ToolType).HasMaxLength(255);
            });

            modelBuilder.Entity<TblMain>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("tblMain");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.AdditionalInfo)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.AnnualCost)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                //entity.Property(e => e.Dns1_1)
                //    .HasColumnName("DNS1_1")
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Dns1_2)
                //    .HasColumnName("DNS1_2")
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Dns1_3)
                //    .HasColumnName("DNS1_3")
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Dns1_4)
                //    .HasColumnName("DNS1_4")
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Dns2_1)
                //    .HasColumnName("DNS2_1")
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Dns2_2)
                //    .HasColumnName("DNS2_2")
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Dns2_3)
                //    .HasColumnName("DNS2_3")
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Dns2_4)
                //    .HasColumnName("DNS2_4")
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Dns3_1)
                //    .HasColumnName("DNS3_1")
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Dns3_2)
                //    .HasColumnName("DNS3_2")
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Dns3_3)
                //    .HasColumnName("DNS3_3")
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Dns3_4)
                //    .HasColumnName("DNS3_4")
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Dnszone)
                //    .HasColumnName("DNSZone")
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                entity.Property(e => e.Eoldate)
                    .HasColumnName("EOLDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Eosdate)
                    .HasColumnName("EOSDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirmwareVersion)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                //entity.Property(e => e.Gateway1)
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Gateway2)
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Gateway3)
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Gateway4)
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Hostname1)
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Hostname2)
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Hostname3)
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Hostname4)
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                entity.Property(e => e.InstalledLocation)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.InstalledLocation2)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.InternalBillingCode)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                //entity.Property(e => e.Ipaddress1)
                //    .HasColumnName("IPAddress1")
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Ipaddress2)
                //    .HasColumnName("IPAddress2")
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Ipaddress3)
                //    .HasColumnName("IPAddress3")
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Ipaddress4)
                //    .HasColumnName("IPAddress4")
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ItemOwnership)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseExpiration).HasColumnType("datetime");

                entity.Property(e => e.LicenseFrequency)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseMethod)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.LicensePartNumber)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseQuantity)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseStatus)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ModelNumber)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyCost)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                //entity.Property(e => e.Netmask1)
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Netmask2)
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Netmask3)
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                //entity.Property(e => e.Netmask4)
                //    .HasMaxLength(128)
                //    .IsUnicode(false);

                entity.Property(e => e.OispinvoiceNum)
                    .HasColumnName("OISPInvoiceNum")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.Poc1).HasColumnName("POC1");

                entity.Property(e => e.Poc2).HasColumnName("POC2");

                entity.Property(e => e.ProductKey)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseCost)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber2)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SoftwareVersion)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.StateAssetTag)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.StorageLocation)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Vendor)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCustomerNum)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.VendorOrderRefNum)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.VendorSiteNum)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Vm_Cpu)
                    .HasColumnName("VM_CPU")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Vm_Os)
                    .HasColumnName("VM_OS")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Vm_Ram)
                    .HasColumnName("VM_Ram")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });
        }

        //public DbSet<InventoryDBRazor.Models.ListVendor> ListVendor { get; set; }

        //public DbSet<InventoryDBRazor.Models.IPInfo> IPInfo { get; set; }

        //public DbSet<InventoryDBRazor.Models.ListVendorPOC> ListVendorPOC { get; set; }
    }
}
