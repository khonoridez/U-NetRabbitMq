using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroRabbit.Transfer.Data.Migrations
{
    public partial class UpdateTransferLogsFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountBalance",
                table: "TransferLogs");

            migrationBuilder.DropColumn(
                name: "AccountType",
                table: "TransferLogs");

            migrationBuilder.AddColumn<int>(
                name: "FromAccount",
                table: "TransferLogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ToAccount",
                table: "TransferLogs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromAccount",
                table: "TransferLogs");

            migrationBuilder.DropColumn(
                name: "ToAccount",
                table: "TransferLogs");

            migrationBuilder.AddColumn<decimal>(
                name: "AccountBalance",
                table: "TransferLogs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "AccountType",
                table: "TransferLogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
