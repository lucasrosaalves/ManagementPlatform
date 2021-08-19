using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMP.Measurements.Domain.CodeList;
using RMP.Measurements.Infra.Data.Configurations.Helpers;

namespace RMP.Measurements.Infra.Data.Configurations.CodeList
{
    public class UomConfiguration : IEntityTypeConfiguration<Uom>
    {
        public void Configure(EntityTypeBuilder<Uom> builder)
        {
            builder.ConfigureBaseCodeListEntity("cl_uom");

            builder
                .Property(b => b.UomClassificationId)
                .HasColumnName("cl_uomclassification_id")
                .IsRequired();

            builder.HasOne(b => b.UomClassification);

            builder
                .Property(b => b.UomTypeId)
                .HasColumnName("cl_uomtype_id")
                .IsRequired();

            builder.HasOne(b => b.UomType);
        }
    }
}
