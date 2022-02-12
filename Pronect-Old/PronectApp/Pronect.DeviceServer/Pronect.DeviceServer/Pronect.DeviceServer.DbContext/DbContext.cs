using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Pronect.DirectoryServer.DbContext.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Pronect.DeviceServer.DbContext
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public virtual DbSet<PronectDevice> PronectDevice { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(@"Server=127.0.0.1;Port=5432;Database=PronectDevices;User Id=postgres;Password=pass4;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PronectDevice>(entity =>
            {
                entity.ToTable("devices");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Account).HasColumnName("account");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PermanentPassword).HasColumnName("permanent_password");

                entity.Property(e => e.PermanentPassword).HasColumnName("temp_password");

                entity.Property(e => e.SignedIn).HasColumnName("signed_in");
            });

        }
    }
}
