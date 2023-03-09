using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BSBookingQuery.Migrations
{
    /// <inheritdoc />
    public partial class newTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Bookings_BookingModelId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "userComments",
                table: "Comments",
                newName: "UserComments");

            migrationBuilder.AlterColumn<int>(
                name: "BookingModelId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Bookings_BookingModelId",
                table: "Comments",
                column: "BookingModelId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Bookings_BookingModelId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "UserComments",
                table: "Comments",
                newName: "userComments");

            migrationBuilder.AlterColumn<int>(
                name: "BookingModelId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Bookings_BookingModelId",
                table: "Comments",
                column: "BookingModelId",
                principalTable: "Bookings",
                principalColumn: "Id");
        }
    }
}
