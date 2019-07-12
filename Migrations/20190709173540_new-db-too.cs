using Microsoft.EntityFrameworkCore.Migrations;

namespace MCTCTicketSystem2.Migrations
{
    public partial class newdbtoo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2ee5ee3-990a-43d0-8a8a-29ea3790888c", "AQAAAAEAACcQAAAAECw95UIgIyKWCRz82HBsqZjOgs256K7wiWyaiyKFYox0TZuWvJB9EM3bm8V6CkA8fg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32df368c-a2d8-45bb-bc7c-686f21211ab6", "AQAAAAEAACcQAAAAEIBSEks3nK86hoAxbMdcbWCTsqo/mDb33aipeSAjZkVt27RBOHuC1ey0ITM+HkdnMA==" });
        }
    }
}
