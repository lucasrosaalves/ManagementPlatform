using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMP.Measurements.Domain.Entities;
using RMP.Measurements.Infra.Data.Configurations.Helpers;

namespace RMP.Measurements.Infra.Data.Configurations.Entities
{
    public class TemplateConfiguration : IEntityTypeConfiguration<Template>
    {
        public void Configure(EntityTypeBuilder<Template> builder)
        {
            builder.ConfigureBaseEntity("rt_template");

            builder
                .Property(b => b.AssetId)
                .HasColumnName("rt_asset_id")
                .IsRequired();

            builder.HasOne(b => b.Asset);

            builder
                .Property(b => b.AssetTypeId)
                .HasColumnName("cl_assettype_id")
                .IsRequired();

            builder.HasOne(b => b.AssetType);
        }
    }
}
