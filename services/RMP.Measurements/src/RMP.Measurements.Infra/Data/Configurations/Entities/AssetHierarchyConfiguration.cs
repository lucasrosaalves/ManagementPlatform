using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMP.Measurements.Domain.Entities;
using RMP.Measurements.Infra.Data.Configurations.Helpers;

namespace RMP.Measurements.Infra.Data.Configurations.Entities
{
    public class AssetHierarchyConfiguration : IEntityTypeConfiguration<AssetHierarchy>
    {
        public void Configure(EntityTypeBuilder<AssetHierarchy> builder)
        {
            builder.ConfigureBaseEntity("rt_assethierarchy");

            builder
                .Property(b => b.ParentId)
                .HasColumnName("parent_id")
                .IsRequired();

            builder
                .HasOne(b => b.Parent);

            builder
                .Property(b => b.ChildId)
                .HasColumnName("child_id")
                .IsRequired();

            builder
                .HasOne(b => b.Child);
        }
    }
}
