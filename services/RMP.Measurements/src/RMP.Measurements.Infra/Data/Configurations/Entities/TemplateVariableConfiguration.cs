using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMP.Measurements.Domain.Entities;
using RMP.Measurements.Infra.Data.Configurations.Helpers;

namespace RMP.Measurements.Infra.Data.Configurations.Entities
{
    public class TemplateVariableConfiguration : IEntityTypeConfiguration<TemplateVariable>
    {
        public void Configure(EntityTypeBuilder<TemplateVariable> builder)
        {
            builder.ConfigureBaseEntity("re_templatevariable");

            builder
                .Property(b => b.TemplateId)
                .HasColumnType("rt_template_id")
                .IsRequired();

            builder.HasOne(b => b.Template);

            builder
                .Property(b => b.MeasurementCategoryTypeId)
                .HasColumnName("re_measurementcategorytotype")
                .IsRequired();

            builder.HasOne(b => b.MeasurementCategoryType);

            builder
                .Property(b => b.MeasurementCategoryTypeId)
                .HasColumnName("re_measurementcategorytotype")
                .IsRequired();

            builder.HasOne(b => b.MeasurementCategoryType);

            builder
                .Property(b => b.UomId)
                .HasColumnName("cl_uom_id")
                .IsRequired();

            builder.HasOne(b => b.Uom);

            builder
                .Property(b => b.DataTypeId)
                .HasColumnName("cl_datatype_id")
                .IsRequired();

            builder.HasOne(b => b.DataType);

            builder
                .Property(b => b.Editable)
                .HasColumnName("editable")
                .HasDefaultValue(true)
                .IsRequired();

            builder
                .Property(b => b.Required)
                .HasColumnName("required")
                .HasDefaultValue(true)
                .IsRequired();
        }
    }
}
