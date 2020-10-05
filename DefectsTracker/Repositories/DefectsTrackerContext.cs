using DefectsTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace DefectsTracker.Repositories
{
    public partial class DefectsTrackerContext : DbContext
    {
        public DefectsTrackerContext()
        { }
        public DefectsTrackerContext(DbContextOptions<DefectsTrackerContext> options)
            : base(options)
        { }

        public virtual DbSet<Defect> Defects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Defect>(entity =>
            {
                entity.ToTable("defect");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssignedTo).HasColumnName("assigned_user");

                entity.Property(e => e.Created)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefectPriority).HasColumnName("defect_priority");

                entity.Property(e => e.Description)
                    .HasColumnName("description");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("defect_title")
                    .HasMaxLength(50);

                entity.Property(e => e.DefectType).HasColumnName("defect_type");

                entity.Property(e => e.Modified)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReportedBy).HasColumnName("reported_user");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
