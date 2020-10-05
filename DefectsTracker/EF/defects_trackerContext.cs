using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DefectsTracker.EF
{
    public partial class defects_trackerContext : DbContext
    {
        public defects_trackerContext(DbContextOptions<defects_trackerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Defect> Defect { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Defect>(entity =>
            {
                entity.ToTable("defect");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssignedUser).HasColumnName("assigned_user");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("date");

                entity.Property(e => e.DefectPriority).HasColumnName("defect_priority");

                entity.Property(e => e.DefectTitle)
                    .IsRequired()
                    .HasColumnName("defect_title")
                    .HasMaxLength(50);

                entity.Property(e => e.DefectType).HasColumnName("defect_type");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("date");

                entity.Property(e => e.ReportedUser).HasColumnName("reported_user");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
