using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMP.Measurements.Domain.Common;

namespace RMP.Measurements.Infra.Data.Configurations.Helpers
{
    public static class EntityConfigurationExtensions
    {
        public static void ConfigureBaseEntity<T>(this EntityTypeBuilder<T> builder, string tableName) where T : class, IEntity
        {
            builder.ToTable(tableName);

            builder
                .HasKey(b => b.Id);

            builder
                .Property(b => b.Id)
                .HasColumnName($"{tableName}_id");

            builder
                .Property(b => b.Deleted)
                .HasColumnName("deleted")
                .HasDefaultValue(false)
                .IsRequired();

            builder
                .Property(b => b.TransactionId)
                .HasColumnName("transaction_id")
                .IsRequired();

            builder
                .Property(b => b.CreatedAt)
                .HasColumnName("created_at")
                .IsRequired();

            builder
                .Property(b => b.UpdatedAt)
                .HasColumnName("updated_at")
                .IsRequired();
        }

        public static void ConfigureBaseCodeListEntity<T>(this EntityTypeBuilder<T> builder, string tableName) where T : class, ICodeListEntity
        {
            builder.ConfigureBaseEntity(tableName);

            builder
                .Property(b => b.ShortString)
                .HasColumnName($"{tableName}_value_shortstring")
                .HasColumnType("varchar")
                .HasMaxLength(50)          
                .IsRequired();

            builder
                .Property(b => b.LongString)
                .HasColumnName($"{tableName}_value_longstring")
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder
                .HasIndex(b => b.ShortString)
                .IsUnique()
                .HasDatabaseName($"uq_{tableName}_value_shortstring");
        }
    }
}
