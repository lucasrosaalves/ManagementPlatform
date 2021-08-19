using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMP.Measurements.Domain.CodeList;
using RMP.Measurements.Infra.Data.Configurations.Helpers;

namespace RMP.Measurements.Infra.Data.Configurations.CodeList
{
    public class MeasurementTypeConfiguration : IEntityTypeConfiguration<MeasurementType>
    {
        public void Configure(EntityTypeBuilder<MeasurementType> builder)
        {
            builder.ConfigureBaseCodeListEntity("cl_measurementtype");
        }
    }
}
