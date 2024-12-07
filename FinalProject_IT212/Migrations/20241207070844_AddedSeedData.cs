using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject_IT212.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quantity_Orders_OrdersOrderId",
                table: "Quantity");

            migrationBuilder.AlterColumn<int>(
                name: "OrdersOrderId",
                table: "Quantity",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "BalloonGirl657@Treemail.com", "Lisa", "Hedgington" },
                    { 2, "CrysanthimumPedals@Treemail.com", "Margaret", "Tanding" },
                    { 3, "CamileIanHearts@Treemail.com", "Camile", "Smith" },
                    { 4, "RocksNFries@Treemail.com", "Michael", "Odderton" },
                    { 5, "PearlsAndBlooms347@YahootieHoo.com", "Helen", "McBride" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "OrderCost" },
                values: new object[,]
                {
                    { 1, 1, 53.78m },
                    { 2, 4, 89.64m },
                    { 3, 3, 32.78m },
                    { 4, 2, 338.31m },
                    { 5, 1, 127.44m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 53.78m, "Cream floral", "Blouse" },
                    { 2, 73.66m, "Brown cordoroy", "Bell Bottoms" },
                    { 3, 65.99m, "Green moose decal", "Hoodie" },
                    { 4, 7.99m, "Black", "Basic T-shirt" },
                    { 5, 32.78m, "Maroon lace", "Crop Top" }
                });

            migrationBuilder.InsertData(
                table: "Quantity",
                columns: new[] { "QuantityId", "OrdersOrderId", "ProductId", "ProductQty" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 2, 1 },
                    { 3, 2, 4, 2 },
                    { 4, 3, 5, 1 },
                    { 5, 4, 1, 2 },
                    { 6, 4, 5, 1 },
                    { 7, 4, 3, 3 },
                    { 8, 5, 1, 1 },
                    { 9, 5, 2, 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Quantity_Orders_OrdersOrderId",
                table: "Quantity",
                column: "OrdersOrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quantity_Orders_OrdersOrderId",
                table: "Quantity");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Quantity",
                keyColumn: "QuantityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quantity",
                keyColumn: "QuantityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quantity",
                keyColumn: "QuantityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quantity",
                keyColumn: "QuantityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quantity",
                keyColumn: "QuantityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Quantity",
                keyColumn: "QuantityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Quantity",
                keyColumn: "QuantityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Quantity",
                keyColumn: "QuantityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Quantity",
                keyColumn: "QuantityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "OrdersOrderId",
                table: "Quantity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Quantity_Orders_OrdersOrderId",
                table: "Quantity",
                column: "OrdersOrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");
        }
    }
}
