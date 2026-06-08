using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WatchTower_API.Migrations
{
    /// <inheritdoc />
    public partial class MonitorMonitorChecksCreations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonitorChecks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    MonitorId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StatusCode = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ResponseTimeMs = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    IsSuccess = table.Column<int>(type: "NUMBER(1)", nullable: false),
                    CheckedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitorChecks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Url = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsActive = table.Column<int>(type: "NUMBER(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonitorChecks");

            migrationBuilder.DropTable(
                name: "Monitors");
        }
    }
}
