using DefectsTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DefectsTracker.Repositories
{
    public partial class DefectsTrackerContext : DbContext
    {
        public DefectsTrackerContext(DbContextOptions<DefectsTrackerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Defect> Defects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Defect>(entity =>
            {
                entity.ToTable("defect");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer: ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                entity.Property(e => e.AssignedTo)
                    .HasColumnName("assigned_user")
                    .HasColumnType("int");

                entity.Property(e => e.Created)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Priority)
                    .IsRequired()
                    .HasColumnName("defect_priority")
                    .HasColumnType("tinyint");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("defect_title")
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("defect_type")
                    .HasColumnType("tinyint");

                entity.Property(e => e.Modified)
                    .IsRequired()
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReportedBy)
                    .IsRequired()
                    .HasColumnName("reported_user")
                    .HasColumnType("int");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
