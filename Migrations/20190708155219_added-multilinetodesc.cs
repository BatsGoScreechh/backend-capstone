using Microsoft.EntityFrameworkCore.Migrations;

namespace MCTCTicketSystem2.Migrations
{
    public partial class addedmultilinetodesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "433e6e05-4ae9-4886-a357-b744f8cd2579", "AQAAAAEAACcQAAAAEBp7b3BZ4JNW+96m9YwhV1fR8leZRErwMe/zS5Us87ZVMB0bUYvT67luNPonAPJiRQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c3c4130b-bb8e-4d96-9194-f00a3f5ea43e", "AQAAAAEAACcQAAAAEDbs1G6svI380E8d2SFw6pUER4MR8pJKwzImTWahDW90OpOyPMw4+cHCRXzPEqtOpA==" });
        }
    }
}
