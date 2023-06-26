using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddReasonField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 6, 26, 20, 56, 28, 944, DateTimeKind.Local).AddTicks(6389), new DateTime(2023, 6, 26, 20, 56, 28, 944, DateTimeKind.Local).AddTicks(6410) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reason",
                table: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 1, 18, 8, 17, 10, 116, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 1, 18, 8, 17, 10, 116, DateTimeKind.Local).AddTicks(7439) });
        }
    }
}
