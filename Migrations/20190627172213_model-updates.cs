using Microsoft.EntityFrameworkCore.Migrations;

namespace MCTCTicketSystem2.Migrations
{
    public partial class modelupdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Platform",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Category",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "isAdmin",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b6fd2d06-cf98-42f9-af56-6f711573fc8a", "AQAAAAEAACcQAAAAEHXkv75Bg+atVZa7MZsmrRBMo+CJMRvaAGb7s+yV+3B7KZUQFpmUV2ZxkWtfI86yKA==" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Ticket_TicketId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Platform_Ticket_TicketId",
                table: "Platform");

            migrationBuilder.DropIndex(
                name: "IX_Platform_TicketId",
                table: "Platform");

            migrationBuilder.DropIndex(
                name: "IX_Category_TicketId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Platform");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<bool>(
                name: "isAdmin",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0c9beed-7a40-4c33-b91b-2ad3f33d1abc", "AQAAAAEAACcQAAAAEPBRIZHlP0V83VpOvrhtgLI9ftMDYBXAcBDf5fCbMh9LIvLjIgkvqX3dPCGk1v9z4g==" });
        }
    }
}
