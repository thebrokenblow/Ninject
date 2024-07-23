using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp4.Migrations
{
    /// <inheritdoc />
    public partial class Change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_WorkerJournals_WorkerJournalId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_WorkerJournalId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "WorkerJournalId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "WorkerJournals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkerJournals_EmployeeId",
                table: "WorkerJournals",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerJournals_Employees_EmployeeId",
                table: "WorkerJournals",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkerJournals_Employees_EmployeeId",
                table: "WorkerJournals");

            migrationBuilder.DropIndex(
                name: "IX_WorkerJournals_EmployeeId",
                table: "WorkerJournals");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "WorkerJournals");

            migrationBuilder.AddColumn<int>(
                name: "WorkerJournalId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_WorkerJournalId",
                table: "Employees",
                column: "WorkerJournalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_WorkerJournals_WorkerJournalId",
                table: "Employees",
                column: "WorkerJournalId",
                principalTable: "WorkerJournals",
                principalColumn: "Id");
        }
    }
}
