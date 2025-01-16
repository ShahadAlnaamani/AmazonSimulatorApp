using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmazonSimulatorApp.Migrations
{
    /// <inheritdoc />
    public partial class fixingcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Users_UserID",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderOID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductPID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_ClientCID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_Clients_ClientCID",
                table: "ProductReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_Products_ProductPID",
                table: "ProductReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryCatID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sellers_SellerSID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Users_UserID",
                table: "Sellers");

            migrationBuilder.DropIndex(
                name: "IX_Sellers_UserID",
                table: "Sellers");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryCatID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SellerSID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_ProductReviews_ClientCID",
                table: "ProductReviews");

            migrationBuilder.DropIndex(
                name: "IX_ProductReviews_ProductPID",
                table: "ProductReviews");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ClientCID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderOID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ProductPID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_Clients_UserID",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "CategoryCatID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SellerSID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ClientCID",
                table: "ProductReviews");

            migrationBuilder.DropColumn(
                name: "ProductPID",
                table: "ProductReviews");

            migrationBuilder.DropColumn(
                name: "ClientCID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderOID",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ProductPID",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Clients");

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    PImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PID = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.PImageID);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductPID",
                        column: x => x.ProductPID,
                        principalTable: "Products",
                        principalColumn: "PID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_UID",
                table: "Sellers",
                column: "UID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CatID",
                table: "Products",
                column: "CatID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SID",
                table: "Products",
                column: "SID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_CID",
                table: "ProductReviews",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_PID",
                table: "ProductReviews",
                column: "PID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CID",
                table: "Orders",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_PID",
                table: "OrderDetails",
                column: "PID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_UID",
                table: "Clients",
                column: "UID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductPID",
                table: "ProductImages",
                column: "ProductPID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Users_UID",
                table: "Clients",
                column: "UID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OID",
                table: "OrderDetails",
                column: "OID",
                principalTable: "Orders",
                principalColumn: "OID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_PID",
                table: "OrderDetails",
                column: "PID",
                principalTable: "Products",
                principalColumn: "PID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_CID",
                table: "Orders",
                column: "CID",
                principalTable: "Clients",
                principalColumn: "CID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_Clients_CID",
                table: "ProductReviews",
                column: "CID",
                principalTable: "Clients",
                principalColumn: "CID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_Products_PID",
                table: "ProductReviews",
                column: "PID",
                principalTable: "Products",
                principalColumn: "PID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CatID",
                table: "Products",
                column: "CatID",
                principalTable: "Categories",
                principalColumn: "CatID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sellers_SID",
                table: "Products",
                column: "SID",
                principalTable: "Sellers",
                principalColumn: "SID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Users_UID",
                table: "Sellers",
                column: "UID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Users_UID",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_PID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_CID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_Clients_CID",
                table: "ProductReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_Products_PID",
                table: "ProductReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CatID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sellers_SID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Users_UID",
                table: "Sellers");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_Sellers_UID",
                table: "Sellers");

            migrationBuilder.DropIndex(
                name: "IX_Products_CatID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_ProductReviews_CID",
                table: "ProductReviews");

            migrationBuilder.DropIndex(
                name: "IX_ProductReviews_PID",
                table: "ProductReviews");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_PID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_Clients_UID",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Sellers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryCatID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SellerSID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClientCID",
                table: "ProductReviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductPID",
                table: "ProductReviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClientCID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderOID",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductPID",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_UserID",
                table: "Sellers",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryCatID",
                table: "Products",
                column: "CategoryCatID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SellerSID",
                table: "Products",
                column: "SellerSID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_ClientCID",
                table: "ProductReviews",
                column: "ClientCID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_ProductPID",
                table: "ProductReviews",
                column: "ProductPID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientCID",
                table: "Orders",
                column: "ClientCID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderOID",
                table: "OrderDetails",
                column: "OrderOID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductPID",
                table: "OrderDetails",
                column: "ProductPID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_UserID",
                table: "Clients",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Users_UserID",
                table: "Clients",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderOID",
                table: "OrderDetails",
                column: "OrderOID",
                principalTable: "Orders",
                principalColumn: "OID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductPID",
                table: "OrderDetails",
                column: "ProductPID",
                principalTable: "Products",
                principalColumn: "PID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_ClientCID",
                table: "Orders",
                column: "ClientCID",
                principalTable: "Clients",
                principalColumn: "CID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_Clients_ClientCID",
                table: "ProductReviews",
                column: "ClientCID",
                principalTable: "Clients",
                principalColumn: "CID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_Products_ProductPID",
                table: "ProductReviews",
                column: "ProductPID",
                principalTable: "Products",
                principalColumn: "PID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryCatID",
                table: "Products",
                column: "CategoryCatID",
                principalTable: "Categories",
                principalColumn: "CatID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sellers_SellerSID",
                table: "Products",
                column: "SellerSID",
                principalTable: "Sellers",
                principalColumn: "SID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Users_UserID",
                table: "Sellers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
