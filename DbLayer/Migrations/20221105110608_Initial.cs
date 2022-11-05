using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DbLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EvaluationTasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EvaluationTasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EvaluationTasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Customers",
                table: "EvaluationTasks");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "EvaluationTasks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Patronymic = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: false),
                    PowerOfAttorney = table.Column<int>(type: "integer", nullable: false),
                    PowerOfAttorneyNumber = table.Column<string>(type: "text", nullable: false),
                    PowerOfAttorneyFirstDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PowerOfAttorneyBeforeDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Directors_Persons_Id",
                        column: x => x.Id,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrivatePersons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Serial = table.Column<string>(type: "text", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: false),
                    Division = table.Column<string>(type: "text", nullable: false),
                    DivisionCode = table.Column<string>(type: "text", nullable: false),
                    DivisionDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivatePersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrivatePersons_Persons_Id",
                        column: x => x.Id,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameFullOpf = table.Column<string>(type: "text", nullable: false),
                    NameShortOpf = table.Column<string>(type: "text", nullable: false),
                    NameFull = table.Column<string>(type: "text", nullable: false),
                    NameShort = table.Column<string>(type: "text", nullable: false),
                    FullOpf = table.Column<string>(type: "text", nullable: false),
                    ShortOpf = table.Column<string>(type: "text", nullable: false),
                    Ogrn = table.Column<string>(type: "text", nullable: false),
                    OgrnDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Inn = table.Column<string>(type: "text", nullable: false),
                    Kpp = table.Column<string>(type: "text", nullable: false),
                    Bank = table.Column<string>(type: "text", nullable: false),
                    Bik = table.Column<string>(type: "text", nullable: false),
                    PayAccount = table.Column<string>(type: "text", nullable: false),
                    CorrAccount = table.Column<string>(type: "text", nullable: false),
                    DirectorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Customers = table.Column<string>(type: "text", nullable: false),
                    PrivatePersonId = table.Column<int>(type: "integer", nullable: false),
                    OrganizationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_PrivatePersons_PrivatePersonId",
                        column: x => x.PrivatePersonId,
                        principalTable: "PrivatePersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationTasks_CustomerId",
                table: "EvaluationTasks",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_OrganizationId",
                table: "Customers",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PrivatePersonId",
                table: "Customers",
                column: "PrivatePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_DirectorId",
                table: "Organizations",
                column: "DirectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_EvaluationTasks_Customers_CustomerId",
                table: "EvaluationTasks",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvaluationTasks_Customers_CustomerId",
                table: "EvaluationTasks");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "PrivatePersons");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_EvaluationTasks_CustomerId",
                table: "EvaluationTasks");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "EvaluationTasks");

            migrationBuilder.AddColumn<string>(
                name: "Customers",
                table: "EvaluationTasks",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "EvaluationTasks",
                columns: new[] { "Id", "Customers", "DateApplication", "IntendedUse", "Number", "Target" },
                values: new object[,]
                {
                    { 1, "Organization", new DateTime(2022, 10, 29, 2, 49, 42, 568, DateTimeKind.Utc).AddTicks(4641), "Для принятия управленческих решений", 1235, "MarketValue" },
                    { 2, "PrivatePerson", new DateTime(2022, 10, 29, 2, 49, 42, 568, DateTimeKind.Utc).AddTicks(4643), "Для предоставления в банк", 540, "MarketAndLiquidationValue" },
                    { 3, "PrivatePerson", new DateTime(2022, 10, 29, 2, 49, 42, 568, DateTimeKind.Utc).AddTicks(4644), "Для принятия управленческих решений", 284, "MarketValue" }
                });
        }
    }
}
