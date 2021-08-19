using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RMP.Measurements.Infra.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cl_assettype",
                columns: table => new
                {
                    cl_assettype_id = table.Column<Guid>(type: "uuid", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    transaction_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    cl_assettype_value_shortstring = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    cl_assettype_value_longstring = table.Column<string>(type: "varchar", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cl_assettype", x => x.cl_assettype_id);
                });

            migrationBuilder.CreateTable(
                name: "cl_datatype",
                columns: table => new
                {
                    cl_datatype_id = table.Column<Guid>(type: "uuid", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    transaction_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    cl_datatype_value_shortstring = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    cl_datatype_value_longstring = table.Column<string>(type: "varchar", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cl_datatype", x => x.cl_datatype_id);
                });

            migrationBuilder.CreateTable(
                name: "cl_measurementcategory",
                columns: table => new
                {
                    cl_measurementcategory_id = table.Column<Guid>(type: "uuid", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    transaction_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    cl_measurementcategory_value_shortstring = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    cl_measurementcategory_value_longstring = table.Column<string>(type: "varchar", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cl_measurementcategory", x => x.cl_measurementcategory_id);
                });

            migrationBuilder.CreateTable(
                name: "cl_measurementtype",
                columns: table => new
                {
                    cl_measurementtype_id = table.Column<Guid>(type: "uuid", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    transaction_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    cl_measurementtype_value_shortstring = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    cl_measurementtype_value_longstring = table.Column<string>(type: "varchar", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cl_measurementtype", x => x.cl_measurementtype_id);
                });

            migrationBuilder.CreateTable(
                name: "cl_uomclassification",
                columns: table => new
                {
                    cl_uomclassification_id = table.Column<Guid>(type: "uuid", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    transaction_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    cl_uomclassification_value_shortstring = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    cl_uomclassification_value_longstring = table.Column<string>(type: "varchar", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cl_uomclassification", x => x.cl_uomclassification_id);
                });

            migrationBuilder.CreateTable(
                name: "cl_uomtype",
                columns: table => new
                {
                    cl_uomtype_id = table.Column<Guid>(type: "uuid", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    transaction_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    cl_uomtype_value_shortstring = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    cl_uomtype_value_longstring = table.Column<string>(type: "varchar", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cl_uomtype", x => x.cl_uomtype_id);
                });

            migrationBuilder.CreateTable(
                name: "rt_asset",
                columns: table => new
                {
                    rt_asset_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 255, nullable: false),
                    master = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    cl_assettype_id = table.Column<Guid>(type: "uuid", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    transaction_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rt_asset", x => x.rt_asset_id);
                    table.ForeignKey(
                        name: "FK_rt_asset_cl_assettype_cl_assettype_id",
                        column: x => x.cl_assettype_id,
                        principalTable: "cl_assettype",
                        principalColumn: "cl_assettype_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cl_uom",
                columns: table => new
                {
                    cl_uom_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cl_uomtype_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cl_uomclassification_id = table.Column<Guid>(type: "uuid", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    transaction_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    cl_uom_value_shortstring = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    cl_uom_value_longstring = table.Column<string>(type: "varchar", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cl_uom", x => x.cl_uom_id);
                    table.ForeignKey(
                        name: "FK_cl_uom_cl_uomclassification_cl_uomclassification_id",
                        column: x => x.cl_uomclassification_id,
                        principalTable: "cl_uomclassification",
                        principalColumn: "cl_uomclassification_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cl_uom_cl_uomtype_cl_uomtype_id",
                        column: x => x.cl_uomtype_id,
                        principalTable: "cl_uomtype",
                        principalColumn: "cl_uomtype_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "re_measurementcategorytotype",
                columns: table => new
                {
                    re_measurementcategorytotype_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cl_assettype_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cl_measurementtype_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cl_measurementcategory_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cl_uomtype_id = table.Column<Guid>(type: "uuid", nullable: false),
                    description = table.Column<string>(type: "varchar", maxLength: 255, nullable: false),
                    required = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    transaction_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_re_measurementcategorytotype", x => x.re_measurementcategorytotype_id);
                    table.ForeignKey(
                        name: "FK_re_measurementcategorytotype_cl_assettype_cl_assettype_id",
                        column: x => x.cl_assettype_id,
                        principalTable: "cl_assettype",
                        principalColumn: "cl_assettype_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_re_measurementcategorytotype_cl_measurementcategory_cl_meas~",
                        column: x => x.cl_measurementcategory_id,
                        principalTable: "cl_measurementcategory",
                        principalColumn: "cl_measurementcategory_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_re_measurementcategorytotype_cl_measurementtype_cl_measurem~",
                        column: x => x.cl_measurementtype_id,
                        principalTable: "cl_measurementtype",
                        principalColumn: "cl_measurementtype_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_re_measurementcategorytotype_cl_uomtype_cl_uomtype_id",
                        column: x => x.cl_uomtype_id,
                        principalTable: "cl_uomtype",
                        principalColumn: "cl_uomtype_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rt_assethierarchy",
                columns: table => new
                {
                    rt_assethierarchy_id = table.Column<Guid>(type: "uuid", nullable: false),
                    parent_id = table.Column<Guid>(type: "uuid", nullable: false),
                    child_id = table.Column<Guid>(type: "uuid", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    transaction_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rt_assethierarchy", x => x.rt_assethierarchy_id);
                    table.ForeignKey(
                        name: "FK_rt_assethierarchy_rt_asset_child_id",
                        column: x => x.child_id,
                        principalTable: "rt_asset",
                        principalColumn: "rt_asset_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rt_assethierarchy_rt_asset_parent_id",
                        column: x => x.parent_id,
                        principalTable: "rt_asset",
                        principalColumn: "rt_asset_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rt_template",
                columns: table => new
                {
                    rt_template_id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    rt_asset_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cl_assettype_id = table.Column<Guid>(type: "uuid", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    transaction_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rt_template", x => x.rt_template_id);
                    table.ForeignKey(
                        name: "FK_rt_template_cl_assettype_cl_assettype_id",
                        column: x => x.cl_assettype_id,
                        principalTable: "cl_assettype",
                        principalColumn: "cl_assettype_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rt_template_rt_asset_rt_asset_id",
                        column: x => x.rt_asset_id,
                        principalTable: "rt_asset",
                        principalColumn: "rt_asset_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rt_assetmeasurement",
                columns: table => new
                {
                    rt_assetmeasurement_id = table.Column<Guid>(type: "uuid", nullable: false),
                    timestamp = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    value = table.Column<string>(type: "varchar", maxLength: 255, nullable: false),
                    manualmeasurement = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    newormodified = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    rt_asset_id = table.Column<Guid>(type: "uuid", nullable: false),
                    re_measurementcategorytotype_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cl_uom_id = table.Column<Guid>(type: "uuid", nullable: true),
                    cl_datatype_id = table.Column<Guid>(type: "uuid", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    transaction_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rt_assetmeasurement", x => x.rt_assetmeasurement_id);
                    table.ForeignKey(
                        name: "FK_rt_assetmeasurement_cl_datatype_cl_datatype_id",
                        column: x => x.cl_datatype_id,
                        principalTable: "cl_datatype",
                        principalColumn: "cl_datatype_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rt_assetmeasurement_cl_uom_cl_uom_id",
                        column: x => x.cl_uom_id,
                        principalTable: "cl_uom",
                        principalColumn: "cl_uom_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_rt_assetmeasurement_re_measurementcategorytotype_re_measure~",
                        column: x => x.re_measurementcategorytotype_id,
                        principalTable: "re_measurementcategorytotype",
                        principalColumn: "re_measurementcategorytotype_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rt_assetmeasurement_rt_asset_rt_asset_id",
                        column: x => x.rt_asset_id,
                        principalTable: "rt_asset",
                        principalColumn: "rt_asset_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "re_templatevariable",
                columns: table => new
                {
                    re_templatevariable_id = table.Column<Guid>(type: "uuid", nullable: false),
                    rt_template_id = table.Column<Guid>(type: "uuid", nullable: false),
                    re_measurementcategorytotype = table.Column<Guid>(type: "uuid", nullable: false),
                    cl_uom_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cl_datatype_id = table.Column<Guid>(type: "uuid", nullable: false),
                    editable = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    required = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    transaction_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_re_templatevariable", x => x.re_templatevariable_id);
                    table.ForeignKey(
                        name: "FK_re_templatevariable_cl_datatype_cl_datatype_id",
                        column: x => x.cl_datatype_id,
                        principalTable: "cl_datatype",
                        principalColumn: "cl_datatype_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_re_templatevariable_cl_uom_cl_uom_id",
                        column: x => x.cl_uom_id,
                        principalTable: "cl_uom",
                        principalColumn: "cl_uom_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_re_templatevariable_re_measurementcategorytotype_re_measure~",
                        column: x => x.re_measurementcategorytotype,
                        principalTable: "re_measurementcategorytotype",
                        principalColumn: "re_measurementcategorytotype_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_re_templatevariable_rt_template_rt_template_id",
                        column: x => x.rt_template_id,
                        principalTable: "rt_template",
                        principalColumn: "rt_template_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "uq_cl_assettype_value_shortstring",
                table: "cl_assettype",
                column: "cl_assettype_value_shortstring",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "uq_cl_datatype_value_shortstring",
                table: "cl_datatype",
                column: "cl_datatype_value_shortstring",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "uq_cl_measurementcategory_value_shortstring",
                table: "cl_measurementcategory",
                column: "cl_measurementcategory_value_shortstring",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "uq_cl_measurementtype_value_shortstring",
                table: "cl_measurementtype",
                column: "cl_measurementtype_value_shortstring",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cl_uom_cl_uomclassification_id",
                table: "cl_uom",
                column: "cl_uomclassification_id");

            migrationBuilder.CreateIndex(
                name: "IX_cl_uom_cl_uomtype_id",
                table: "cl_uom",
                column: "cl_uomtype_id");

            migrationBuilder.CreateIndex(
                name: "uq_cl_uom_value_shortstring",
                table: "cl_uom",
                column: "cl_uom_value_shortstring",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "uq_cl_uomclassification_value_shortstring",
                table: "cl_uomclassification",
                column: "cl_uomclassification_value_shortstring",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "uq_cl_uomtype_value_shortstring",
                table: "cl_uomtype",
                column: "cl_uomtype_value_shortstring",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_re_measurementcategorytotype_cl_assettype_id",
                table: "re_measurementcategorytotype",
                column: "cl_assettype_id");

            migrationBuilder.CreateIndex(
                name: "IX_re_measurementcategorytotype_cl_measurementcategory_id",
                table: "re_measurementcategorytotype",
                column: "cl_measurementcategory_id");

            migrationBuilder.CreateIndex(
                name: "IX_re_measurementcategorytotype_cl_measurementtype_id",
                table: "re_measurementcategorytotype",
                column: "cl_measurementtype_id");

            migrationBuilder.CreateIndex(
                name: "IX_re_measurementcategorytotype_cl_uomtype_id",
                table: "re_measurementcategorytotype",
                column: "cl_uomtype_id");

            migrationBuilder.CreateIndex(
                name: "IX_re_templatevariable_cl_datatype_id",
                table: "re_templatevariable",
                column: "cl_datatype_id");

            migrationBuilder.CreateIndex(
                name: "IX_re_templatevariable_cl_uom_id",
                table: "re_templatevariable",
                column: "cl_uom_id");

            migrationBuilder.CreateIndex(
                name: "IX_re_templatevariable_re_measurementcategorytotype",
                table: "re_templatevariable",
                column: "re_measurementcategorytotype");

            migrationBuilder.CreateIndex(
                name: "IX_re_templatevariable_rt_template_id",
                table: "re_templatevariable",
                column: "rt_template_id");

            migrationBuilder.CreateIndex(
                name: "IX_rt_asset_cl_assettype_id",
                table: "rt_asset",
                column: "cl_assettype_id");

            migrationBuilder.CreateIndex(
                name: "IX_rt_assethierarchy_child_id",
                table: "rt_assethierarchy",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_rt_assethierarchy_parent_id",
                table: "rt_assethierarchy",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_rt_assetmeasurement_cl_datatype_id",
                table: "rt_assetmeasurement",
                column: "cl_datatype_id");

            migrationBuilder.CreateIndex(
                name: "IX_rt_assetmeasurement_cl_uom_id",
                table: "rt_assetmeasurement",
                column: "cl_uom_id");

            migrationBuilder.CreateIndex(
                name: "IX_rt_assetmeasurement_re_measurementcategorytotype_id",
                table: "rt_assetmeasurement",
                column: "re_measurementcategorytotype_id");

            migrationBuilder.CreateIndex(
                name: "IX_rt_assetmeasurement_rt_asset_id",
                table: "rt_assetmeasurement",
                column: "rt_asset_id");

            migrationBuilder.CreateIndex(
                name: "IX_rt_template_cl_assettype_id",
                table: "rt_template",
                column: "cl_assettype_id");

            migrationBuilder.CreateIndex(
                name: "IX_rt_template_rt_asset_id",
                table: "rt_template",
                column: "rt_asset_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "re_templatevariable");

            migrationBuilder.DropTable(
                name: "rt_assethierarchy");

            migrationBuilder.DropTable(
                name: "rt_assetmeasurement");

            migrationBuilder.DropTable(
                name: "rt_template");

            migrationBuilder.DropTable(
                name: "cl_datatype");

            migrationBuilder.DropTable(
                name: "cl_uom");

            migrationBuilder.DropTable(
                name: "re_measurementcategorytotype");

            migrationBuilder.DropTable(
                name: "rt_asset");

            migrationBuilder.DropTable(
                name: "cl_uomclassification");

            migrationBuilder.DropTable(
                name: "cl_measurementcategory");

            migrationBuilder.DropTable(
                name: "cl_measurementtype");

            migrationBuilder.DropTable(
                name: "cl_uomtype");

            migrationBuilder.DropTable(
                name: "cl_assettype");
        }
    }
}
