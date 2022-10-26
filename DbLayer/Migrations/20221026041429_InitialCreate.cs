using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbLayer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvaluationTasks_Contracts_ContractId",
                table: "EvaluationTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_EvaluationTasks_Reports_ReportId",
                table: "EvaluationTasks");

            migrationBuilder.DropIndex(
                name: "IX_EvaluationTasks_ContractId",
                table: "EvaluationTasks");

            migrationBuilder.DropIndex(
                name: "IX_EvaluationTasks_ReportId",
                table: "EvaluationTasks");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "EvaluationTasks");

            migrationBuilder.DropColumn(
                name: "InspectionFeaures",
                table: "EvaluationTasks");

            migrationBuilder.RenameColumn(
                name: "ReportId",
                table: "EvaluationTasks",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "InspectionDate",
                table: "EvaluationTasks",
                newName: "DateApplication");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Number",
                table: "EvaluationTasks",
                newName: "ReportId");

            migrationBuilder.RenameColumn(
                name: "DateApplication",
                table: "EvaluationTasks",
                newName: "InspectionDate");

            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "EvaluationTasks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "InspectionFeaures",
                table: "EvaluationTasks",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationTasks_ContractId",
                table: "EvaluationTasks",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationTasks_ReportId",
                table: "EvaluationTasks",
                column: "ReportId");

            migrationBuilder.AddForeignKey(
                name: "FK_EvaluationTasks_Contracts_ContractId",
                table: "EvaluationTasks",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EvaluationTasks_Reports_ReportId",
                table: "EvaluationTasks",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
