using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mytra.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dytyryt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "UserSettings",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "UserSettings",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserSettings",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "UserSettings",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "UserDetail",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "UserDetail",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserDetail",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "UserDetail",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "UserAuthentication",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "UserAuthentication",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserAuthentication",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "UserAuthentication",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "User",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "User",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "User",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "User",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Skills",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Skills",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Skills",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Skills",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ManagerSettings",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "ManagerSettings",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ManagerSettings",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "ManagerSettings",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ManagerDetail",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "ManagerDetail",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ManagerDetail",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "ManagerDetail",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ManagerAuthentication",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "ManagerAuthentication",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ManagerAuthentication",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "ManagerAuthentication",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Manager",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Manager",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Manager",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Manager",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Language",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Language",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Language",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Language",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "JobPostingVisit",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "JobPostingVisit",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "JobPostingVisit",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "JobPostingVisit",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "JobPostingDetail",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "JobPostingDetail",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "JobPostingDetail",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "JobPostingDetail",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "JobPostingApply",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "JobPostingApply",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "JobPostingApply",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "JobPostingApply",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "JobPosting",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "JobPosting",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "JobPosting",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "JobPosting",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Institution",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Institution",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Institution",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Institution",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "College",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "College",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "College",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "College",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateSkills",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateSkills",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateSkills",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateSkills",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateSettings",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateSettings",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateSettings",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateSettings",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateReferance",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateReferance",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateReferance",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateReferance",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidatePhoto",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidatePhoto",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidatePhoto",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidatePhoto",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateLanguage",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateLanguage",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateLanguage",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateLanguage",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateExperience",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateExperience",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateExperience",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateExperience",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateEducation",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateEducation",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateEducation",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateEducation",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateDetail",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateDetail",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateDetail",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateDetail",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateContact",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateContact",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateContact",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateContact",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateCertificate",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateCertificate",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateCertificate",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateCertificate",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateAuthentication",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateAuthentication",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateAuthentication",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateAuthentication",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Candidate",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Candidate",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Candidate",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Candidate",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Candidate",
                type: "VARCHAR(100)",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Candidate",
                type: "VARCHAR(100)",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Candidate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "UserSettings",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "UserSettings",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserSettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "UserSettings",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "UserDetail",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "UserDetail",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "UserDetail",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "UserAuthentication",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "UserAuthentication",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserAuthentication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "UserAuthentication",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "User",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "User",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "User",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Skills",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Skills",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Skills",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ManagerSettings",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "ManagerSettings",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ManagerSettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "ManagerSettings",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ManagerDetail",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "ManagerDetail",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ManagerDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "ManagerDetail",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ManagerAuthentication",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "ManagerAuthentication",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ManagerAuthentication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "ManagerAuthentication",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Manager",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Manager",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Manager",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Manager",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Language",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Language",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Language",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Language",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "JobPostingVisit",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "JobPostingVisit",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "JobPostingVisit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "JobPostingVisit",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "JobPostingDetail",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "JobPostingDetail",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "JobPostingDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "JobPostingDetail",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "JobPostingApply",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "JobPostingApply",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "JobPostingApply",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "JobPostingApply",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "JobPosting",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "JobPosting",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "JobPosting",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "JobPosting",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Institution",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Institution",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Institution",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Institution",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "College",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "College",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "College",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "College",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateSkills",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateSkills",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateSkills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateSkills",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateSettings",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateSettings",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateSettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateSettings",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateReferance",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateReferance",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateReferance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateReferance",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidatePhoto",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidatePhoto",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidatePhoto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidatePhoto",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateLanguage",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateLanguage",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateLanguage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateLanguage",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateExperience",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateExperience",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateExperience",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateExperience",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateEducation",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateEducation",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateEducation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateEducation",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateDetail",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateDetail",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateDetail",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateContact",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateContact",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateContact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateContact",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateCertificate",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateCertificate",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateCertificate",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateCertificate",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CandidateAuthentication",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "CandidateAuthentication",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CandidateAuthentication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CandidateAuthentication",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Candidate",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Candidate",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Candidate",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 6);
        }
    }
}
