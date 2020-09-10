using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsData.Migrations
{
    public partial class ChangeFileSizeType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "282175b3-aa5f-4a60-8e55-23f06b1b5ec6");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "64cfae44-62d6-4f61-8d21-4740cf8ebe40", "AQAAAAEAACcQAAAAELOvjeDGDh18UXWffKaAbCf9VPiO3DkyyTNzw1TgDjrtst4KdbvZBvFdmkUlq85c4Q==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2020, 9, 9, 19, 26, 54, 359, DateTimeKind.Local).AddTicks(9973));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "191ba370-90df-4183-b793-2e9e31519302");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f9eba5c-f08a-42e0-a819-ed73d6803814", "AQAAAAEAACcQAAAAEG13GtBHR7wqCnrmsLPlitgIaych7OpNurkgBieA1V4Lkp5AXGam5OgLTzsgrvuxiQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2020, 9, 7, 19, 33, 20, 988, DateTimeKind.Local).AddTicks(4601));
        }
    }
}
