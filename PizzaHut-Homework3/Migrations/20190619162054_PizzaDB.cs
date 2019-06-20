using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaHut.Migrations
{
    public partial class PizzaDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_User_UserID",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "ID");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Address", "City", "Email", "Name", "Phone" },
                values: new object[] { 1, "Partizanska", "Skopje", "bojan@abc.com", "Bojan", "078123123" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Address", "City", "Email", "Name", "Phone" },
                values: new object[] { 2, "Vodnjanska", "Stip", "viktor@abc.com", "Viktor", "078123123" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Address", "City", "Email", "Name", "Phone" },
                values: new object[] { 3, "R. Luxemburg", "Bitola", "dejan@abc.com", "Dejan", "078123123" });

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Users_UserID",
                table: "Order",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Users_UserID",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_User_UserID",
                table: "Order",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
