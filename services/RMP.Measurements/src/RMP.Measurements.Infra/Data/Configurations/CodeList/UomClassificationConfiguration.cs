using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMP.Measurements.Domain.CodeList;
using RMP.Measurements.Infra.Data.Configurations.Helpers;

namespace RMP.Measurements.Infra.Data.Configurations.CodeList
{
    public class UomClassificationConfiguration : IEntityTypeConfiguration<UomClassification>
    {
        public void Configure(EntityTypeBuilder<UomClassification> builder)
        {
            builder.ConfigureBaseCodeListEntity("cl_uomclassification");
        }
    }
}
