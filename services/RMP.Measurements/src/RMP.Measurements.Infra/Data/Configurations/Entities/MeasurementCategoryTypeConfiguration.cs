using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMP.Measurements.Domain.Entities;
using RMP.Measurements.Infra.Data.Configurations.Helpers;

namespace RMP.Measurements.Infra.Data.Configurations.Entities
{
    public class MeasurementCategoryTypeConfiguration : IEntityTypeConfiguration<MeasurementCategoryType>
    {
        public void Configure(EntityTypeBuilder<MeasurementCategoryType> builder)
        {
            builder.ConfigureBaseEntity("re_measurementcategorytotype");

            builder
                .Property(b => b.AssetTypeId)
                .HasColumnName("cl_assettype_id")
                .IsRequired();

            builder
                .HasOne(b => b.AssetType);

            builder
                .Property(b => b.MeasurementTypeId)
                .HasColumnName("cl_measurementtype_id")
                .IsRequired();

            builder
                .HasOne(b => b.MeasurementType);


            builder
                .Property(b => b.MeasurementCategoryId)
                .HasColumnName("cl_measurementcategory_id")
                .IsRequired();

            builder
                .HasOne(b => b.MeasurementCategory);

            builder
                .Property(b => b.UomTypeId)
                .HasColumnName("cl_uomtype_id")
                .IsRequired();

            builder
                .HasOne(b => b.UomType);

            builder
                .Property(b => b.Description)
                .HasColumnName("description")
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder
                .Property(b => b.Required)
                .HasColumnName("required")
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}
