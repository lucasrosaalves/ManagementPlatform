using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMP.Measurements.Domain.CodeList;
using RMP.Measurements.Infra.Data.Configurations.Helpers;

namespace RMP.Measurements.Infra.Data.Configurations.CodeList
{
    public class MeasurementCategoryConfiguration : IEntityTypeConfiguration<MeasurementCategory>
    {
        public void Configure(EntityTypeBuilder<MeasurementCategory> builder)
        {
            builder.ConfigureBaseCodeListEntity("cl_measurementcategory");
        }
    }
}
