using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class not1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_ListPassengersPassengerId",
                table: "FlightPassenger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.DropIndex(
                name: "IX_FlightPassenger_ListPassengersPassengerId",
                table: "FlightPassenger");

            migrationBuilder.DropColumn(
                name: "PassengerId",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "ListPassengersPassengerId",
                table: "FlightPassenger");

            migrationBuilder.AlterColumn<string>(
                name: "PassportNumber",
                table: "Passengers",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ListPassengersPassportNumber",
                table: "FlightPassenger",
                type: "nvarchar(7)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers",
                column: "PassportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "FlightsFlightId", "ListPassengersPassportNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_FlightPassenger_ListPassengersPassportNumber",
                table: "FlightPassenger",
                column: "ListPassengersPassportNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_ListPassengersPassportNumber",
                table: "FlightPassenger",
                column: "ListPassengersPassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_ListPassengersPassportNumber",
                table: "FlightPassenger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.DropIndex(
                name: "IX_FlightPassenger_ListPassengersPassportNumber",
                table: "FlightPassenger");

            migrationBuilder.DropColumn(
                name: "ListPassengersPassportNumber",
                table: "FlightPassenger");

            migrationBuilder.AlterColumn<string>(
                name: "PassportNumber",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AddColumn<int>(
                name: "PassengerId",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ListPassengersPassengerId",
                table: "FlightPassenger",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers",
                column: "PassengerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "FlightsFlightId", "ListPassengersPassengerId" });

            migrationBuilder.CreateIndex(
                name: "IX_FlightPassenger_ListPassengersPassengerId",
                table: "FlightPassenger",
                column: "ListPassengersPassengerId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_ListPassengersPassengerId",
                table: "FlightPassenger",
                column: "ListPassengersPassengerId",
                principalTable: "Passengers",
                principalColumn: "PassengerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
