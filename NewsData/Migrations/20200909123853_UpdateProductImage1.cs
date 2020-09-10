using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsData.Migrations
{
    public partial class UpdateProductImage1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "a3f87f67-ec34-4491-8ed4-f5457b268180");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a88fe30-1180-4e4b-b4e0-6d9f3fa64939", "AQAAAAEAACcQAAAAEEnF7faF0c6t4RnHlo6Ba0167XE+Rhpx8EwmKNl4MSHjlywBRTB8djEuSCo6JsteSw==" });

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
                value: new DateTime(2020, 9, 9, 19, 38, 51, 659, DateTimeKind.Local).AddTicks(8440));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
