using ChurchDirectory.DbContext.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ChurchDirectory.DbContext
{
    public class DirectoryDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public virtual DbSet<Family> Families { get; set; }

        public virtual DbSet<Child> Children { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(@"Server=127.0.0.1;Port=5432;Database=WeaverlandChurchDirectory;User Id=postgres;Password=pass4;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Family>(entity => 
                {
                    entity.ToTable("families");

                    entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                    entity.Property(e => e.RecordNumber).HasColumnName("record_number");

                    entity.Property(e => e.FirstName).HasColumnName("first_name");

                    entity.Property(e => e.LastName).HasColumnName("last_name");

                    entity.Property(e => e.ParentId).HasColumnName("parent_id");

                    entity.Property(e => e.BirthDate).HasColumnName("birthdate");

                    entity.Property(e => e.DeathDate).HasColumnName("deathdate");

                    entity.Property(e => e.MarriedDate).HasColumnName("marrieddate");

                    entity.Property(e => e.Spouse).HasColumnName("spouse");

                    entity.Property(e => e.SpouseId).HasColumnName("spouse_id");

                    entity.Property(e => e.SpouseBirthDate).HasColumnName("spouse_birthdate");

                    entity.Property(e => e.SpouseDeathDate).HasColumnName("spouse_deathdate");

                    entity.Property(e => e.Line1).HasColumnName("line1");

                    entity.Property(e => e.City).HasColumnName("city");

                    entity.Property(e => e.State).HasColumnName("state");

                    entity.Property(e => e.Zip).HasColumnName("zip");

                    entity.Property(e => e.Member).HasColumnName("member");

                    entity.Property(e => e.Phone1).HasColumnName("phone1");

                    entity.Property(e => e.Phone2).HasColumnName("phone2");

                    entity.Property(e => e.Comment1).HasColumnName("comment1");

                    entity.Property(e => e.Comment2).HasColumnName("comment2");
                });

            modelBuilder.Entity<Child>(entity =>
            {
                entity.ToTable("children");

                entity.Property(e => e.Id)
                .HasColumnName("id")
                .ValueGeneratedNever();

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.BirthDate).HasColumnName("birthdate");

                entity.Property(e => e.DeathDate).HasColumnName("deathdate");

                entity.Property(e => e.Married).HasColumnName("married");

                entity.Property(e => e.Member).HasColumnName("member");

                entity.Property(e => e.Comment1).HasColumnName("comment1");
            });
        }
    }
}
