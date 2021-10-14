using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KArtistMicroservice.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KArtists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgencyId = table.Column<int>(type: "int", nullable: false),
                    ArtistType = table.Column<int>(type: "int", nullable: false),
                    DebutDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KArtists", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Agencies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "EDAM Entertainment" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agencies");

            migrationBuilder.DropTable(
                name: "KArtists");
        }
    }
}
