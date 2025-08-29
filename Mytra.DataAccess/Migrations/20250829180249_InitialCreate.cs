using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mytra.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateAuthentication",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateAuthentication", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateCertificate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateCertificate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateContact",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateContact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateEducation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateEducation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateExperience",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateExperience", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateLanguage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateLanguage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidatePhoto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatePhoto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateReferance",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateReferance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "College",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_College", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Institution",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institution", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobPosting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPosting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobPostingApply",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPostingApply", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobPostingDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPostingDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobPostingVisit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPostingVisit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManagerAuthentication",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerAuthentication", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManagerDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManagerSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAuthentication",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAuthentication", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSettings", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidate");

            migrationBuilder.DropTable(
                name: "CandidateAuthentication");

            migrationBuilder.DropTable(
                name: "CandidateCertificate");

            migrationBuilder.DropTable(
                name: "CandidateContact");

            migrationBuilder.DropTable(
                name: "CandidateDetail");

            migrationBuilder.DropTable(
                name: "CandidateEducation");

            migrationBuilder.DropTable(
                name: "CandidateExperience");

            migrationBuilder.DropTable(
                name: "CandidateLanguage");

            migrationBuilder.DropTable(
                name: "CandidatePhoto");

            migrationBuilder.DropTable(
                name: "CandidateReferance");

            migrationBuilder.DropTable(
                name: "CandidateSettings");

            migrationBuilder.DropTable(
                name: "CandidateSkills");

            migrationBuilder.DropTable(
                name: "College");

            migrationBuilder.DropTable(
                name: "Institution");

            migrationBuilder.DropTable(
                name: "JobPosting");

            migrationBuilder.DropTable(
                name: "JobPostingApply");

            migrationBuilder.DropTable(
                name: "JobPostingDetail");

            migrationBuilder.DropTable(
                name: "JobPostingVisit");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "ManagerAuthentication");

            migrationBuilder.DropTable(
                name: "ManagerDetail");

            migrationBuilder.DropTable(
                name: "ManagerSettings");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserAuthentication");

            migrationBuilder.DropTable(
                name: "UserDetail");

            migrationBuilder.DropTable(
                name: "UserSettings");
        }
    }
}
