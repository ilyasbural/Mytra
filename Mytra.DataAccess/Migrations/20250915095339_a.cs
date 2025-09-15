using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mytra.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "UserAuthentication",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "UserAuthentication",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "UserAuthentication",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "UserAuthentication",
                type: "VARCHAR(200)",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 1);

			migrationBuilder.AddColumn<DateTime>(
	            name: "RefreshTokenExpireTime",
	            table: "UserAuthentication",
	            type: "DATETIME",
	            nullable: false,
	            defaultValueSql: "GETDATE()")
	            .Annotation("Relational:ColumnOrder", 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "UserAuthentication");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpireTime",
                table: "UserAuthentication");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "UserAuthentication",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "UserAuthentication",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "UserAuthentication",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 5);
        }
    }
}
