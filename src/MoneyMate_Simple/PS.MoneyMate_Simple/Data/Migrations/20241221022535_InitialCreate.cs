using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PS.MoneyMate_Simple.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConversionRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromCurrencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToCurrencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConvertedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConversionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConversionRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromCurrencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToCurrencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRates", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConversionRequests");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "ExchangeRates");
        }
    }
}
