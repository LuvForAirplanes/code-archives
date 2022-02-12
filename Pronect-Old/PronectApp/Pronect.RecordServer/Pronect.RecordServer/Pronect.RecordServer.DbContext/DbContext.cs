using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Pronect.DirectoryServer.DbContext.Models;
using Pronect.RecordServer.DbContext.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Pronect.RecordServer.DbContext
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public virtual DbSet<ConnectionRecord> ConnectionRecord { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(@"Server=127.0.0.1;Port=5432;Database=PronectConnectionRecords;User Id=postgres;Password=pass4;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConnectionRecord>(entity =>
            {
                entity.ToTable("connnection_records");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.HostConnectionId).HasColumnName("host");

                entity.Property(e => e.RemoteConnectionId).HasColumnName("remote");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.EndTime).HasColumnName("end_time");
            });

        }
    }
}
