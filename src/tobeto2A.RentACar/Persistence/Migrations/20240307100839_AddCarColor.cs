using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCarColor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("5ca1ad9b-65d2-4849-aab1-d8e28cbcb967"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ec78e9a-21a1-4cf7-aadf-603d32740736"));

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CarColors.Admin", null },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CarColors.Read", null },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CarColors.Write", null },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CarColors.Create", null },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CarColors.Update", null },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CarColors.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("b1628cda-c741-4040-95ee-1605c992d1a2"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 206, 49, 101, 71, 81, 28, 145, 99, 30, 114, 53, 182, 129, 9, 133, 9, 111, 242, 48, 177, 97, 177, 141, 182, 97, 180, 217, 50, 161, 227, 218, 167, 81, 179, 144, 141, 135, 141, 1, 14, 23, 188, 51, 233, 241, 169, 153, 195, 41, 17, 68, 111, 121, 124, 87, 246, 14, 132, 159, 191, 252, 19, 202, 36 }, new byte[] { 182, 96, 244, 56, 142, 139, 174, 194, 157, 225, 47, 46, 75, 158, 159, 222, 110, 136, 93, 114, 138, 27, 38, 183, 93, 104, 41, 58, 215, 241, 4, 122, 184, 104, 63, 144, 102, 180, 158, 140, 32, 0, 141, 119, 166, 131, 107, 217, 6, 161, 164, 239, 143, 93, 225, 224, 109, 236, 115, 191, 0, 165, 54, 190, 71, 22, 59, 1, 20, 83, 68, 72, 11, 27, 31, 65, 34, 162, 96, 194, 223, 164, 100, 11, 106, 122, 243, 137, 190, 127, 59, 237, 104, 232, 115, 84, 84, 123, 196, 200, 21, 125, 242, 115, 171, 121, 57, 229, 131, 140, 223, 123, 121, 8, 105, 116, 226, 211, 145, 178, 89, 148, 201, 50, 94, 31, 166, 223 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("0332f835-d70a-4e2d-b1b3-f1e82554a692"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("b1628cda-c741-4040-95ee-1605c992d1a2") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("0332f835-d70a-4e2d-b1b3-f1e82554a692"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1628cda-c741-4040-95ee-1605c992d1a2"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("2ec78e9a-21a1-4cf7-aadf-603d32740736"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 9, 113, 138, 150, 79, 215, 205, 103, 218, 2, 156, 104, 121, 90, 214, 237, 216, 16, 14, 228, 163, 209, 198, 166, 110, 146, 130, 106, 29, 81, 140, 147, 19, 116, 71, 92, 176, 250, 202, 68, 253, 160, 54, 8, 50, 86, 255, 118, 206, 87, 192, 38, 156, 157, 48, 42, 118, 137, 113, 137, 105, 246, 197, 93 }, new byte[] { 52, 253, 13, 211, 145, 62, 208, 194, 70, 159, 93, 210, 61, 174, 239, 12, 39, 61, 150, 132, 118, 160, 21, 219, 191, 111, 200, 58, 129, 7, 131, 132, 27, 86, 67, 51, 178, 162, 50, 77, 189, 206, 136, 211, 85, 65, 82, 164, 33, 72, 69, 239, 65, 201, 206, 227, 177, 72, 236, 88, 78, 67, 227, 63, 34, 41, 141, 180, 58, 76, 242, 3, 10, 90, 29, 201, 135, 219, 187, 89, 197, 47, 140, 8, 191, 91, 222, 68, 25, 97, 85, 68, 201, 152, 27, 192, 227, 44, 184, 98, 167, 84, 81, 124, 238, 244, 77, 217, 155, 230, 89, 15, 226, 75, 236, 143, 44, 90, 154, 127, 64, 170, 171, 6, 176, 58, 195, 179 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("5ca1ad9b-65d2-4849-aab1-d8e28cbcb967"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("2ec78e9a-21a1-4cf7-aadf-603d32740736") });
        }
    }
}
