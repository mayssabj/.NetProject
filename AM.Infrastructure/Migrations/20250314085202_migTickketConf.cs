using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migTickketConf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationFlightPassenger");

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    FlightFk = table.Column<int>(type: "int", nullable: false),
                    PassengerFk = table.Column<string>(type: "nvarchar(7)", nullable: false),
                    prix = table.Column<double>(type: "float", nullable: false),
                    siege = table.Column<int>(type: "int", nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false),
                    MyflightFlightId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => new { x.FlightFk, x.PassengerFk });
                    table.ForeignKey(
                        name: "FK_Ticket_Flights_MyflightFlightId",
                        column: x => x.MyflightFlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Passengers_PassengerFk",
                        column: x => x.PassengerFk,
                        principalTable: "Passengers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_MyflightFlightId",
                table: "Ticket",
                column: "MyflightFlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PassengerFk",
                table: "Ticket",
                column: "PassengerFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.CreateTable(
                name: "ReservationFlightPassenger",
                columns: table => new
                {
                    FlightsFlightId = table.Column<int>(type: "int", nullable: false),
                    ListPassengersPassportNumber = table.Column<string>(type: "nvarchar(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationFlightPassenger", x => new { x.FlightsFlightId, x.ListPassengersPassportNumber });
                    table.ForeignKey(
                        name: "FK_ReservationFlightPassenger_Flights_FlightsFlightId",
                        column: x => x.FlightsFlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationFlightPassenger_Passengers_ListPassengersPassportNumber",
                        column: x => x.ListPassengersPassportNumber,
                        principalTable: "Passengers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationFlightPassenger_ListPassengersPassportNumber",
                table: "ReservationFlightPassenger",
                column: "ListPassengersPassportNumber");
        }
    }
}
