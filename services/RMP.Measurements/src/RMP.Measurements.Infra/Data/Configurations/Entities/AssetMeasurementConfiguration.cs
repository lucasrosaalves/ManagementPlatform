using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMP.Measurements.Domain.Entities;
using RMP.Measurements.Infra.Data.Configurations.Helpers;

namespace RMP.Measurements.Infra.Data.Configurations.Entities
{
    public class AssetMeasurementConfiguration : IEntityTypeConfiguration<AssetMeasurement>
    {
        public void Configure(EntityTypeBuilder<AssetMeasurement> builder)
        {
            builder.ConfigureBaseEntity("rt_assetmeasurement");

            builder
                .Property(b => b.Timestamp)
                .HasColumnName("timestamp")
                .IsRequired();

            builder
                .Property(b => b.Value)
                .HasColumnName("value")
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder
                .Property(b => b.ManualMeasurement)
                .HasColumnName("manualmeasurement")
                .HasDefaultValue(false)
                .IsRequired();


            builder
                .Property(b => b.NewOrModified)
                .HasColumnName("newormodified")
                .HasDefaultValue(false)
                .IsRequired();


            builder
                .Property(b => b.AssetId)
                .HasColumnName("rt_asset_id")
                .IsRequired();

          
            builder.HasOne(b => b.Asset);

            builder
                .Property(b => b.MeasurementCategoryTypeId)
                .HasColumnName("re_measurementcategorytotype_id")
                .IsRequired();

            builder.HasOne(b => b.MeasurementCategoryType);

            builder
                .Property(b => b.UomId)
                .HasColumnName("cl_uom_id");

            builder.HasOne(b => b.Uom);

            builder
                .Property(b => b.DataTypeId)
                .HasColumnName("cl_datatype_id")
                .IsRequired();

            builder.HasOne(b => b.DataType);

        }
    }
}
