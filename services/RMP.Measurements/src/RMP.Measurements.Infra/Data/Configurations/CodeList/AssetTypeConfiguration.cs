using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMP.Measurements.Domain.CodeList;
using RMP.Measurements.Infra.Data.Configurations.Helpers;

namespace RMP.Measurements.Infra.Data.Configurations.CodeList
{
    public class AssetTypeConfiguration : IEntityTypeConfiguration<AssetType>
    {
        public void Configure(EntityTypeBuilder<AssetType> builder)
        {
            builder.ConfigureBaseCodeListEntity("cl_assettype");
        }
    }
}
