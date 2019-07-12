using Microsoft.EntityFrameworkCore.Migrations;

namespace MCTCTicketSystem2.Migrations
{
    public partial class newdbticketupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isAdmin",
                table: "Ticket",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b63130e-51c8-49fc-afd7-27a98b0c962f", "AQAAAAEAACcQAAAAEL6VHIyBxAm2EiGwH+Bui4NTILbb0DQUMq7sUrAKghFq5ArDVs+cDNnKJo2FoLNsfA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAdmin",
                table: "Ticket");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb9ada78-5a31-4eff-9df9-4ff5442a15c4", "AQAAAAEAACcQAAAAEObaX+hWFTNb6jjwDIpOZIItuVUjghbPRdMhF+6tcQwIr8/bV8GBlcVcFLaYS/Qv3g==" });
        }
    }
}
