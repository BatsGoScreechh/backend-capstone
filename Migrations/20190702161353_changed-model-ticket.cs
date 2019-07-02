using Microsoft.EntityFrameworkCore.Migrations;

namespace MCTCTicketSystem2.Migrations
{
    public partial class changedmodelticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Ticket",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e3c845ec-3cdc-46ad-8185-5f62692913e3", "AQAAAAEAACcQAAAAEGbi6xwkbIuNgqKJiJGUtnrFoszJ+hxBl0mDuG48BRe0UYQko/DdN+Z3YsdsGZByrQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Ticket");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c728dd8-1b10-4c6e-8815-80a1affd8ba4", "AQAAAAEAACcQAAAAEGxSNZvzP3sGEqC8tpv/DGeCkNAM8fHtRBYs+k+sbWxfgsXWk1m9Rc+ShRuK/SkflA==" });
        }
    }
}
