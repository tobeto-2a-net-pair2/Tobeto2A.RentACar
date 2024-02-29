using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("066281ac-3c0c-41b9-a17b-37b4f66a0bd8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25f5f451-61ba-4337-99c3-d974037293d3"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("c30986af-fd9e-4585-ac2d-51f31d047bb9"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 210, 165, 214, 242, 172, 98, 38, 221, 9, 171, 205, 31, 175, 62, 77, 106, 4, 178, 18, 115, 42, 205, 192, 66, 171, 66, 81, 123, 32, 9, 210, 20, 46, 104, 212, 50, 51, 101, 230, 71, 252, 9, 138, 69, 62, 252, 135, 190, 36, 82, 121, 234, 148, 108, 207, 22, 169, 129, 135, 10, 92, 5, 102, 70 }, new byte[] { 233, 140, 125, 146, 104, 5, 168, 8, 26, 208, 96, 178, 122, 64, 136, 148, 11, 186, 81, 48, 37, 163, 71, 45, 138, 145, 168, 72, 33, 180, 250, 209, 172, 25, 48, 214, 21, 66, 198, 88, 35, 59, 50, 18, 162, 27, 210, 164, 184, 162, 192, 19, 0, 188, 33, 110, 86, 181, 14, 47, 213, 221, 76, 97, 28, 21, 227, 129, 108, 6, 203, 76, 23, 121, 69, 32, 178, 160, 87, 140, 53, 105, 153, 138, 141, 132, 54, 94, 104, 103, 92, 122, 8, 18, 44, 149, 105, 81, 254, 161, 209, 6, 25, 187, 176, 129, 106, 86, 160, 83, 37, 241, 3, 74, 50, 249, 50, 233, 184, 159, 135, 23, 27, 28, 253, 54, 34, 41 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("b6a065cc-685b-4855-b0fd-93489f176de0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("c30986af-fd9e-4585-ac2d-51f31d047bb9") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b6a065cc-685b-4855-b0fd-93489f176de0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c30986af-fd9e-4585-ac2d-51f31d047bb9"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("25f5f451-61ba-4337-99c3-d974037293d3"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 2, 187, 69, 211, 81, 36, 222, 239, 210, 79, 109, 47, 119, 96, 157, 192, 112, 117, 13, 96, 112, 86, 214, 180, 133, 157, 160, 75, 91, 166, 215, 110, 6, 101, 176, 246, 134, 64, 154, 28, 3, 192, 172, 61, 16, 240, 218, 107, 168, 154, 91, 155, 180, 27, 58, 69, 188, 230, 205, 55, 239, 174, 185, 70 }, new byte[] { 40, 124, 10, 74, 145, 75, 138, 163, 175, 131, 201, 29, 34, 225, 27, 208, 113, 55, 6, 219, 224, 213, 109, 142, 84, 162, 234, 223, 55, 104, 130, 146, 250, 238, 103, 211, 89, 244, 15, 69, 241, 5, 88, 55, 111, 165, 29, 4, 121, 219, 42, 65, 209, 131, 248, 52, 3, 139, 218, 32, 207, 251, 97, 156, 180, 128, 45, 10, 170, 249, 134, 212, 219, 147, 111, 18, 195, 145, 57, 140, 64, 64, 64, 180, 79, 86, 40, 218, 54, 228, 175, 249, 186, 96, 232, 101, 214, 15, 83, 105, 91, 243, 18, 242, 105, 174, 8, 245, 241, 103, 212, 22, 212, 21, 89, 4, 172, 227, 69, 196, 27, 8, 208, 103, 211, 4, 14, 101 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("066281ac-3c0c-41b9-a17b-37b4f66a0bd8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("25f5f451-61ba-4337-99c3-d974037293d3") });
        }
    }
}
