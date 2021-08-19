﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RMP.Measurements.Infra.Data;

namespace RMP.Measurements.Infra.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210819181045_InitialModel")]
    partial class InitialModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("RMP.Measurements.Domain.CodeList.AssetType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("cl_assettype_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("deleted");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("LongString")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("cl_assettype_value_longstring");

                    b.Property<string>("ShortString")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("cl_assettype_value_shortstring");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid")
                        .HasColumnName("transaction_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("ShortString")
                        .IsUnique()
                        .HasDatabaseName("uq_cl_assettype_value_shortstring");

                    b.ToTable("cl_assettype");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.CodeList.DataType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("cl_datatype_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("deleted");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("LongString")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("cl_datatype_value_longstring");

                    b.Property<string>("ShortString")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("cl_datatype_value_shortstring");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid")
                        .HasColumnName("transaction_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("ShortString")
                        .IsUnique()
                        .HasDatabaseName("uq_cl_datatype_value_shortstring");

                    b.ToTable("cl_datatype");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.CodeList.MeasurementCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("cl_measurementcategory_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("deleted");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("LongString")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("cl_measurementcategory_value_longstring");

                    b.Property<string>("ShortString")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("cl_measurementcategory_value_shortstring");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid")
                        .HasColumnName("transaction_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("ShortString")
                        .IsUnique()
                        .HasDatabaseName("uq_cl_measurementcategory_value_shortstring");

                    b.ToTable("cl_measurementcategory");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.CodeList.MeasurementType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("cl_measurementtype_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("deleted");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("LongString")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("cl_measurementtype_value_longstring");

                    b.Property<string>("ShortString")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("cl_measurementtype_value_shortstring");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid")
                        .HasColumnName("transaction_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("ShortString")
                        .IsUnique()
                        .HasDatabaseName("uq_cl_measurementtype_value_shortstring");

                    b.ToTable("cl_measurementtype");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.CodeList.Uom", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("cl_uom_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("deleted");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("LongString")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("cl_uom_value_longstring");

                    b.Property<string>("ShortString")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("cl_uom_value_shortstring");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid")
                        .HasColumnName("transaction_id");

                    b.Property<Guid>("UomClassificationId")
                        .HasColumnType("uuid")
                        .HasColumnName("cl_uomclassification_id");

                    b.Property<Guid>("UomTypeId")
                        .HasColumnType("uuid")
                        .HasColumnName("cl_uomtype_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("ShortString")
                        .IsUnique()
                        .HasDatabaseName("uq_cl_uom_value_shortstring");

                    b.HasIndex("UomClassificationId");

                    b.HasIndex("UomTypeId");

                    b.ToTable("cl_uom");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.CodeList.UomClassification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("cl_uomclassification_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("deleted");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("LongString")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("cl_uomclassification_value_longstring");

                    b.Property<string>("ShortString")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("cl_uomclassification_value_shortstring");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid")
                        .HasColumnName("transaction_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("ShortString")
                        .IsUnique()
                        .HasDatabaseName("uq_cl_uomclassification_value_shortstring");

                    b.ToTable("cl_uomclassification");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.CodeList.UomType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("cl_uomtype_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("deleted");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("LongString")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("cl_uomtype_value_longstring");

                    b.Property<string>("ShortString")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("cl_uomtype_value_shortstring");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid")
                        .HasColumnName("transaction_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("ShortString")
                        .IsUnique()
                        .HasDatabaseName("uq_cl_uomtype_value_shortstring");

                    b.ToTable("cl_uomtype");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.Entities.Asset", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("rt_asset_id");

                    b.Property<Guid>("AssetTypeId")
                        .HasColumnType("uuid")
                        .HasColumnName("cl_assettype_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("deleted");

                    b.Property<bool>("Master")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("master");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("name");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid")
                        .HasColumnName("transaction_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("AssetTypeId");

                    b.ToTable("rt_asset");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.Entities.AssetHierarchy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("rt_assethierarchy_id");

                    b.Property<Guid>("ChildId")
                        .HasColumnType("uuid")
                        .HasColumnName("child_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("deleted");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uuid")
                        .HasColumnName("parent_id");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid")
                        .HasColumnName("transaction_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("ChildId");

                    b.HasIndex("ParentId");

                    b.ToTable("rt_assethierarchy");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.Entities.AssetMeasurement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("rt_assetmeasurement_id");

                    b.Property<Guid>("AssetId")
                        .HasColumnType("rt_asset_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("DataTypeId")
                        .HasColumnType("cl_datatype_id");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("deleted");

                    b.Property<bool>("ManualMeasurement")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("manualmeasurement");

                    b.Property<Guid>("MeasurementCategoryTypeId")
                        .HasColumnType("re_measurementcategorytotype_id");

                    b.Property<bool>("NewOrModified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("newormodified");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("timestamp");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid")
                        .HasColumnName("transaction_id");

                    b.Property<Guid?>("UomId")
                        .HasColumnType("cl_uom_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("DataTypeId");

                    b.HasIndex("MeasurementCategoryTypeId");

                    b.HasIndex("UomId");

                    b.ToTable("rt_assetmeasurement");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.Entities.MeasurementCategoryType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("re_measurementcategorytotype_id");

                    b.Property<Guid>("AssetTypeId")
                        .HasColumnType("uuid")
                        .HasColumnName("cl_assettype_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("deleted");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("description");

                    b.Property<Guid>("MeasurementCategoryId")
                        .HasColumnType("uuid")
                        .HasColumnName("cl_measurementcategory_id");

                    b.Property<Guid>("MeasurementTypeId")
                        .HasColumnType("uuid")
                        .HasColumnName("cl_measurementtype_id");

                    b.Property<bool>("Required")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("required");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid")
                        .HasColumnName("transaction_id");

                    b.Property<Guid>("UomTypeId")
                        .HasColumnType("uuid")
                        .HasColumnName("cl_uomtype_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("AssetTypeId");

                    b.HasIndex("MeasurementCategoryId");

                    b.HasIndex("MeasurementTypeId");

                    b.HasIndex("UomTypeId");

                    b.ToTable("re_measurementcategorytotype");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.Entities.Template", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("rt_template_id");

                    b.Property<Guid>("AssetId")
                        .HasColumnType("rt_asset_id");

                    b.Property<Guid>("AssetTypeId")
                        .HasColumnType("uuid")
                        .HasColumnName("cl_assettype_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("deleted");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid")
                        .HasColumnName("transaction_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("AssetTypeId");

                    b.ToTable("rt_template");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.Entities.TemplateVariable", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("re_templatevariable_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("DataTypeId")
                        .HasColumnType("uuid")
                        .HasColumnName("cl_datatype_id");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("deleted");

                    b.Property<bool>("Editable")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("editable");

                    b.Property<Guid>("MeasurementCategoryTypeId")
                        .HasColumnType("uuid")
                        .HasColumnName("re_measurementcategorytotype");

                    b.Property<bool>("Required")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("required");

                    b.Property<Guid>("TemplateId")
                        .HasColumnType("rt_template_id");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid")
                        .HasColumnName("transaction_id");

                    b.Property<Guid>("UomId")
                        .HasColumnType("uuid")
                        .HasColumnName("cl_uom_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("DataTypeId");

                    b.HasIndex("MeasurementCategoryTypeId");

                    b.HasIndex("TemplateId");

                    b.HasIndex("UomId");

                    b.ToTable("re_templatevariable");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.CodeList.Uom", b =>
                {
                    b.HasOne("RMP.Measurements.Domain.CodeList.UomClassification", "UomClassification")
                        .WithMany()
                        .HasForeignKey("UomClassificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RMP.Measurements.Domain.CodeList.UomType", "UomType")
                        .WithMany()
                        .HasForeignKey("UomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UomClassification");

                    b.Navigation("UomType");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.Entities.Asset", b =>
                {
                    b.HasOne("RMP.Measurements.Domain.CodeList.AssetType", "AssetType")
                        .WithMany()
                        .HasForeignKey("AssetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssetType");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.Entities.AssetHierarchy", b =>
                {
                    b.HasOne("RMP.Measurements.Domain.Entities.Asset", "Child")
                        .WithMany()
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RMP.Measurements.Domain.Entities.Asset", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Child");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.Entities.AssetMeasurement", b =>
                {
                    b.HasOne("RMP.Measurements.Domain.Entities.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RMP.Measurements.Domain.CodeList.DataType", "DataType")
                        .WithMany()
                        .HasForeignKey("DataTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RMP.Measurements.Domain.Entities.MeasurementCategoryType", "MeasurementCategoryType")
                        .WithMany()
                        .HasForeignKey("MeasurementCategoryTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RMP.Measurements.Domain.CodeList.Uom", "Uom")
                        .WithMany()
                        .HasForeignKey("UomId");

                    b.Navigation("Asset");

                    b.Navigation("DataType");

                    b.Navigation("MeasurementCategoryType");

                    b.Navigation("Uom");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.Entities.MeasurementCategoryType", b =>
                {
                    b.HasOne("RMP.Measurements.Domain.CodeList.AssetType", "AssetType")
                        .WithMany()
                        .HasForeignKey("AssetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RMP.Measurements.Domain.CodeList.MeasurementCategory", "MeasurementCategory")
                        .WithMany()
                        .HasForeignKey("MeasurementCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RMP.Measurements.Domain.CodeList.MeasurementType", "MeasurementType")
                        .WithMany()
                        .HasForeignKey("MeasurementTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RMP.Measurements.Domain.CodeList.UomType", "UomType")
                        .WithMany()
                        .HasForeignKey("UomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssetType");

                    b.Navigation("MeasurementCategory");

                    b.Navigation("MeasurementType");

                    b.Navigation("UomType");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.Entities.Template", b =>
                {
                    b.HasOne("RMP.Measurements.Domain.Entities.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RMP.Measurements.Domain.CodeList.AssetType", "AssetType")
                        .WithMany()
                        .HasForeignKey("AssetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");

                    b.Navigation("AssetType");
                });

            modelBuilder.Entity("RMP.Measurements.Domain.Entities.TemplateVariable", b =>
                {
                    b.HasOne("RMP.Measurements.Domain.CodeList.DataType", "DataType")
                        .WithMany()
                        .HasForeignKey("DataTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RMP.Measurements.Domain.Entities.MeasurementCategoryType", "MeasurementCategoryType")
                        .WithMany()
                        .HasForeignKey("MeasurementCategoryTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RMP.Measurements.Domain.Entities.Template", "Template")
                        .WithMany()
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RMP.Measurements.Domain.CodeList.Uom", "Uom")
                        .WithMany()
                        .HasForeignKey("UomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataType");

                    b.Navigation("MeasurementCategoryType");

                    b.Navigation("Template");

                    b.Navigation("Uom");
                });
#pragma warning restore 612, 618
        }
    }
}
