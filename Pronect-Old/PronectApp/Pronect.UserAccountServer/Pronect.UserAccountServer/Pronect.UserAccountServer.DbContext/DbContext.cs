using Microsoft.EntityFrameworkCore;
using Pronect.UserAccountServer.DbContext.Migrations;
using Pronect.UserAccountServer.DbContext.Models;
using System;

namespace Pronect.UserAccountServer.DbContext
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public virtual DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(@"Server=127.0.0.1;Port=5432;Database=PronectUserAccounts;User Id=postgres;Password=pass4;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.ToTable("user_accounts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.LicenseKey).HasColumnName("license_key");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.DateAcquired).HasColumnName("date_acquired");

                entity.Property(e => e.OwnersName).HasColumnName("owners_name");

                entity.Property(e => e.Devices).HasColumnName("devices");

                entity.Property(e => e.WatchedDevices).HasColumnName("watched_devices");
            });
        }
    }
}
