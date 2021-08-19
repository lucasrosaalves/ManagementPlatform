using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMP.Measurements.Domain.CodeList;
using RMP.Measurements.Infra.Data.Configurations.Helpers;

namespace RMP.Measurements.Infra.Data.Configurations.CodeList
{
    public class DataTypeConfiguration : IEntityTypeConfiguration<DataType>
    {
        public void Configure(EntityTypeBuilder<DataType> builder)
        {
            builder.ConfigureBaseCodeListEntity("cl_datatype");
        }
    }
}
