using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migTpt2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Travelles_Passengers_PassportNumber",
                table: "Travelles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Travelles",
                table: "Travelles");

            migrationBuilder.RenameTable(
                name: "Travelles",
                newName: "Travellers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Travellers",
                table: "Travellers",
                column: "PassportNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Travellers_Passengers_PassportNumber",
                table: "Travellers",
                column: "PassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Travellers_Passengers_PassportNumber",
                table: "Travellers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Travellers",
                table: "Travellers");

            migrationBuilder.RenameTable(
                name: "Travellers",
                newName: "Travelles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Travelles",
                table: "Travelles",
                column: "PassportNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Travelles_Passengers_PassportNumber",
                table: "Travelles",
                column: "PassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
