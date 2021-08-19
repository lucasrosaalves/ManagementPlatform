using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMP.Measurements.Domain.Entities;
using RMP.Measurements.Infra.Data.Configurations.Helpers;

namespace RMP.Measurements.Infra.Data.Configurations.Entities
{
    public class AssetConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.ConfigureBaseEntity("rt_asset");

            builder
                .Property(b => b.Name)
                .HasColumnName("name")
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder
                .Property(b => b.Master)
                .HasColumnName("master")
                .HasDefaultValue(false)
                .IsRequired();

            builder
                .Property(b => b.AssetTypeId)
                .HasColumnName("cl_assettype_id")
                .IsRequired();

            builder
                .HasOne(b => b.AssetType);
        }
    }
}
