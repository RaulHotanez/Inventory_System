using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPurchaseOrderItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItem_Products_ProductId",
                table: "PurchaseOrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItem_PurchaseOrders_PurchaseOrderId",
                table: "PurchaseOrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseOrderItem",
                table: "PurchaseOrderItem");

            migrationBuilder.RenameTable(
                name: "PurchaseOrderItem",
                newName: "PurchaseOrderItems");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrderItem_PurchaseOrderId",
                table: "PurchaseOrderItems",
                newName: "IX_PurchaseOrderItems_PurchaseOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrderItem_ProductId",
                table: "PurchaseOrderItems",
                newName: "IX_PurchaseOrderItems_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseOrderItems",
                table: "PurchaseOrderItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItems_Products_ProductId",
                table: "PurchaseOrderItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItems_PurchaseOrders_PurchaseOrderId",
                table: "PurchaseOrderItems",
                column: "PurchaseOrderId",
                principalTable: "PurchaseOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItems_Products_ProductId",
                table: "PurchaseOrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItems_PurchaseOrders_PurchaseOrderId",
                table: "PurchaseOrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseOrderItems",
                table: "PurchaseOrderItems");

            migrationBuilder.RenameTable(
                name: "PurchaseOrderItems",
                newName: "PurchaseOrderItem");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrderItems_PurchaseOrderId",
                table: "PurchaseOrderItem",
                newName: "IX_PurchaseOrderItem_PurchaseOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrderItems_ProductId",
                table: "PurchaseOrderItem",
                newName: "IX_PurchaseOrderItem_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseOrderItem",
                table: "PurchaseOrderItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItem_Products_ProductId",
                table: "PurchaseOrderItem",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItem_PurchaseOrders_PurchaseOrderId",
                table: "PurchaseOrderItem",
                column: "PurchaseOrderId",
                principalTable: "PurchaseOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
