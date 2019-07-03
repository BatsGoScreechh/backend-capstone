using Microsoft.EntityFrameworkCore.Migrations;

namespace MCTCTicketSystem2.Migrations
{
    public partial class revisedticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff5934ac-6ef6-4f27-8395-d07834c35ce1", "AQAAAAEAACcQAAAAEFv+S3vM31eCctQH7kGHOWanUYCWAGZwsL3EFvHME8HbqYn/MIyKGBA7TNvN9waF3g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e3c845ec-3cdc-46ad-8185-5f62692913e3", "AQAAAAEAACcQAAAAEGbi6xwkbIuNgqKJiJGUtnrFoszJ+hxBl0mDuG48BRe0UYQko/DdN+Z3YsdsGZByrQ==" });
        }
    }
}
