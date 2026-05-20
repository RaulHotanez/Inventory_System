using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCSalesOrderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrder_Customer_CustomerId",
                table: "SalesOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrderItem_SalesOrder_SalesOrderId",
                table: "SalesOrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesOrder",
                table: "SalesOrder");

            migrationBuilder.RenameTable(
                name: "SalesOrder",
                newName: "SalesOrders");

            migrationBuilder.RenameIndex(
                name: "IX_SalesOrder_CustomerId",
                table: "SalesOrders",
                newName: "IX_SalesOrders_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesOrders",
                table: "SalesOrders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrderItem_SalesOrders_SalesOrderId",
                table: "SalesOrderItem",
                column: "SalesOrderId",
                principalTable: "SalesOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrders_Customer_CustomerId",
                table: "SalesOrders",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrderItem_SalesOrders_SalesOrderId",
                table: "SalesOrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrders_Customer_CustomerId",
                table: "SalesOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesOrders",
                table: "SalesOrders");

            migrationBuilder.RenameTable(
                name: "SalesOrders",
                newName: "SalesOrder");

            migrationBuilder.RenameIndex(
                name: "IX_SalesOrders_CustomerId",
                table: "SalesOrder",
                newName: "IX_SalesOrder_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesOrder",
                table: "SalesOrder",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrder_Customer_CustomerId",
                table: "SalesOrder",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrderItem_SalesOrder_SalesOrderId",
                table: "SalesOrderItem",
                column: "SalesOrderId",
                principalTable: "SalesOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
