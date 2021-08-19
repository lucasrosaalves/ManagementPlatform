using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMP.Measurements.Domain.CodeList;
using RMP.Measurements.Infra.Data.Configurations.Helpers;

namespace RMP.Measurements.Infra.Data.Configurations.CodeList
{
    public class UomTypeConfiguration : IEntityTypeConfiguration<UomType>
    {
        public void Configure(EntityTypeBuilder<UomType> builder)
        {
            builder.ConfigureBaseCodeListEntity("cl_uomtype");
        }
    }
}
