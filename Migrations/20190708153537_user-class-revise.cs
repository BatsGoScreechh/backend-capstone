using Microsoft.EntityFrameworkCore.Migrations;

namespace MCTCTicketSystem2.Migrations
{
    public partial class userclassrevise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c3c4130b-bb8e-4d96-9194-f00a3f5ea43e", "AQAAAAEAACcQAAAAEDbs1G6svI380E8d2SFw6pUER4MR8pJKwzImTWahDW90OpOyPMw4+cHCRXzPEqtOpA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff5934ac-6ef6-4f27-8395-d07834c35ce1", "AQAAAAEAACcQAAAAEFv+S3vM31eCctQH7kGHOWanUYCWAGZwsL3EFvHME8HbqYn/MIyKGBA7TNvN9waF3g==" });
        }
    }
}
