using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MCTCTicketSystem2.Migrations
{
    public partial class ticketmodelupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCompleted",
                table: "Ticket",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<string>(
                name: "activeMessage",
                table: "Ticket",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c728dd8-1b10-4c6e-8815-80a1affd8ba4", "AQAAAAEAACcQAAAAEGxSNZvzP3sGEqC8tpv/DGeCkNAM8fHtRBYs+k+sbWxfgsXWk1m9Rc+ShRuK/SkflA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_CategoryId",
                table: "Ticket",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PlatformId",
                table: "Ticket",
                column: "PlatformId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Category_CategoryId",
                table: "Ticket",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Platform_PlatformId",
                table: "Ticket",
                column: "PlatformId",
                principalTable: "Platform",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Category_CategoryId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Platform_PlatformId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_CategoryId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_PlatformId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "activeMessage",
                table: "Ticket");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCompleted",
                table: "Ticket",
                nullable: true,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d7dad1dd-ffbc-4a23-88d2-11c3b8160e80", "AQAAAAEAACcQAAAAEBhA7VoF8GOAQ1bLuCGNWj0gPxRujvzpSqpYqttfDI+DgvmpHJM1hUiafPg/pz49ZQ==" });
        }
    }
}
