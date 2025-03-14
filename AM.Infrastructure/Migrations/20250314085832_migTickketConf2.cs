using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migTickketConf2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Flights_MyflightFlightId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_MyflightFlightId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "MyflightFlightId",
                table: "Ticket");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Flights_FlightFk",
                table: "Ticket",
                column: "FlightFk",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Flights_FlightFk",
                table: "Ticket");

            migrationBuilder.AddColumn<int>(
                name: "MyflightFlightId",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_MyflightFlightId",
                table: "Ticket",
                column: "MyflightFlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Flights_MyflightFlightId",
                table: "Ticket",
                column: "MyflightFlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
