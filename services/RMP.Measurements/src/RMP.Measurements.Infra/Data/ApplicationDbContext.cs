using Microsoft.EntityFrameworkCore;
using RMP.Measurements.Domain.CodeList;
using RMP.Measurements.Domain.Entities;

namespace RMP.Measurements.Infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        //Entities
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetHierarchy> AssetHierarchies { get; set; }
        public DbSet<AssetMeasurement> AssetMeasurements { get; set; }
        public DbSet<MeasurementType> MeasurementTypes { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<TemplateVariable> TemplateVariables { get; set; }


        //Code List
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<DataType> DataTypes { get; set; }
        public DbSet<MeasurementCategory> MeasurementCategories { get; set; }
        public DbSet<MeasurementCategoryType> MeasurementCategoryTypes { get; set; }
        public DbSet<Uom> Uoms { get; set; }
        public DbSet<UomClassification> UomClassifications { get; set; }
        public DbSet<UomType> UomTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
