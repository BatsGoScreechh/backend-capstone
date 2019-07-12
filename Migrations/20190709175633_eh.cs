using Microsoft.EntityFrameworkCore.Migrations;

namespace MCTCTicketSystem2.Migrations
{
    public partial class eh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isActive",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "352f281e-d947-4f4e-9341-52820b735345", "AQAAAAEAACcQAAAAEJFbS0Ha+bQ/LvrvYsZPG9sZi24PHbIr/kzoyYkQoi9dIXBLU5ZQY6HXgTUcV+neSg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "isActive",
                table: "Ticket",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2ee5ee3-990a-43d0-8a8a-29ea3790888c", "AQAAAAEAACcQAAAAECw95UIgIyKWCRz82HBsqZjOgs256K7wiWyaiyKFYox0TZuWvJB9EM3bm8V6CkA8fg==" });
        }
    }
}
