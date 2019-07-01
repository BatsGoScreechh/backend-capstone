using Microsoft.EntityFrameworkCore.Migrations;

namespace MCTCTicketSystem2.Migrations
{
    public partial class ticketmodelupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Ticket_TicketId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Platform_Ticket_TicketId",
                table: "Platform");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_AspNetUsers_UserId1",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_UserId1",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Platform_TicketId",
                table: "Platform");

            migrationBuilder.DropIndex(
                name: "IX_Category_TicketId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Platform");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Category");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d7dad1dd-ffbc-4a23-88d2-11c3b8160e80", "AQAAAAEAACcQAAAAEBhA7VoF8GOAQ1bLuCGNWj0gPxRujvzpSqpYqttfDI+DgvmpHJM1hUiafPg/pz49ZQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_UserId",
                table: "Ticket",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_AspNetUsers_UserId",
                table: "Ticket",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_AspNetUsers_UserId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_UserId",
                table: "Ticket");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Ticket",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Platform",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Category",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b6fd2d06-cf98-42f9-af56-6f711573fc8a", "AQAAAAEAACcQAAAAEHXkv75Bg+atVZa7MZsmrRBMo+CJMRvaAGb7s+yV+3B7KZUQFpmUV2ZxkWtfI86yKA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_UserId1",
                table: "Ticket",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Platform_TicketId",
                table: "Platform",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_TicketId",
                table: "Category",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Ticket_TicketId",
                table: "Category",
                column: "TicketId",
                principalTable: "Ticket",
                principalColumn: "TicketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Platform_Ticket_TicketId",
                table: "Platform",
                column: "TicketId",
                principalTable: "Ticket",
                principalColumn: "TicketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_AspNetUsers_UserId1",
                table: "Ticket",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
