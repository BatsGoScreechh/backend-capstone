using Microsoft.EntityFrameworkCore.Migrations;

namespace MCTCTicketSystem2.Migrations
{
    public partial class newdbticketupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAdmin",
                table: "Ticket");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32df368c-a2d8-45bb-bc7c-686f21211ab6", "AQAAAAEAACcQAAAAEIBSEks3nK86hoAxbMdcbWCTsqo/mDb33aipeSAjZkVt27RBOHuC1ey0ITM+HkdnMA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
