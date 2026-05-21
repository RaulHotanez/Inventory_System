using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCSalesOrderItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrderItem_Products_ProductId",
                table: "SalesOrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrderItem_SalesOrders_SalesOrderId",
                table: "SalesOrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesOrderItem",
                table: "SalesOrderItem");

            migrationBuilder.RenameTable(
                name: "SalesOrderItem",
                newName: "SalesOrderItems");

            migrationBuilder.RenameIndex(
                name: "IX_SalesOrderItem_SalesOrderId",
                table: "SalesOrderItems",
                newName: "IX_SalesOrderItems_SalesOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesOrderItem_ProductId",
                table: "SalesOrderItems",
                newName: "IX_SalesOrderItems_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesOrderItems",
                table: "SalesOrderItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrderItems_Products_ProductId",
                table: "SalesOrderItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrderItems_SalesOrders_SalesOrderId",
                table: "SalesOrderItems",
                column: "SalesOrderId",
                principalTable: "SalesOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrderItems_Products_ProductId",
                table: "SalesOrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrderItems_SalesOrders_SalesOrderId",
                table: "SalesOrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesOrderItems",
                table: "SalesOrderItems");

            migrationBuilder.RenameTable(
                name: "SalesOrderItems",
                newName: "SalesOrderItem");

            migrationBuilder.RenameIndex(
                name: "IX_SalesOrderItems_SalesOrderId",
                table: "SalesOrderItem",
                newName: "IX_SalesOrderItem_SalesOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesOrderItems_ProductId",
                table: "SalesOrderItem",
                newName: "IX_SalesOrderItem_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesOrderItem",
                table: "SalesOrderItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrderItem_Products_ProductId",
                table: "SalesOrderItem",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrderItem_SalesOrders_SalesOrderId",
                table: "SalesOrderItem",
                column: "SalesOrderId",
                principalTable: "SalesOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
