using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mytra.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class hgjhgjk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserSettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserAuthentication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ManagerSettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ManagerDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ManagerAuthentication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Manager",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Language",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "JobPostingVisit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "JobPostingDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "JobPostingApply",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "JobPosting",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Institution",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "College",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CandidateSkills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CandidateSettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CandidateReferance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CandidatePhoto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CandidateLanguage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CandidateExperience",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CandidateEducation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CandidateDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CandidateContact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CandidateCertificate",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CandidateAuthentication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserSettings");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserDetail");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserAuthentication");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ManagerSettings");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ManagerDetail");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ManagerAuthentication");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Manager");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Language");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "JobPostingVisit");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "JobPostingDetail");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "JobPostingApply");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "JobPosting");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Institution");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "College");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CandidateSkills");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CandidateSettings");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CandidateReferance");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CandidatePhoto");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CandidateLanguage");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CandidateExperience");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CandidateEducation");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CandidateDetail");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CandidateContact");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CandidateCertificate");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CandidateAuthentication");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Candidate");
        }
    }
}
