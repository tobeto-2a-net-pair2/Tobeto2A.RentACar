using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1abfc2f6-ffae-4fd1-a20f-8e84e4be080f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57d750fa-7841-482f-beeb-171b4e5f488e"));

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CorporateCustomers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorporateCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CorporateCustomers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndividualCustomers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalIdentity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualCustomers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("64653b06-ee8e-465c-a961-f53d7d01902b"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 91, 198, 30, 9, 37, 96, 19, 26, 244, 149, 204, 228, 65, 117, 101, 9, 212, 100, 253, 189, 250, 212, 15, 43, 133, 23, 1, 76, 107, 5, 219, 45, 192, 35, 124, 168, 237, 104, 235, 136, 40, 223, 117, 57, 120, 39, 193, 90, 118, 252, 136, 71, 200, 42, 126, 251, 223, 158, 196, 32, 195, 232, 55, 58 }, new byte[] { 52, 79, 163, 173, 102, 188, 137, 87, 33, 210, 242, 44, 233, 163, 219, 153, 199, 155, 165, 156, 221, 110, 108, 91, 148, 61, 242, 175, 158, 108, 63, 210, 46, 70, 69, 100, 175, 234, 112, 108, 254, 102, 220, 211, 148, 232, 248, 224, 239, 234, 195, 116, 153, 122, 131, 188, 126, 60, 141, 3, 211, 233, 4, 220, 109, 52, 192, 188, 19, 250, 12, 60, 230, 59, 23, 43, 246, 88, 247, 195, 211, 232, 34, 178, 25, 24, 16, 156, 118, 58, 36, 27, 164, 249, 143, 234, 203, 251, 105, 58, 141, 68, 120, 83, 163, 252, 117, 182, 58, 96, 229, 65, 172, 200, 189, 248, 27, 142, 128, 193, 134, 68, 25, 123, 239, 183, 160, 73 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("55457de0-af80-4093-b898-24a6b84b9961"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("64653b06-ee8e-465c-a961-f53d7d01902b") });

            migrationBuilder.CreateIndex(
                name: "IX_CorporateCustomers_CustomerId",
                table: "CorporateCustomers",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualCustomers_CustomerId",
                table: "IndividualCustomers",
                column: "CustomerId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CorporateCustomers");

            migrationBuilder.DropTable(
                name: "IndividualCustomers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("55457de0-af80-4093-b898-24a6b84b9961"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64653b06-ee8e-465c-a961-f53d7d01902b"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("57d750fa-7841-482f-beeb-171b4e5f488e"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 193, 3, 75, 1, 128, 23, 149, 160, 1, 107, 220, 221, 168, 102, 236, 102, 143, 247, 183, 15, 143, 119, 188, 63, 147, 69, 146, 166, 240, 0, 18, 192, 174, 91, 39, 181, 7, 177, 205, 183, 74, 113, 84, 146, 5, 193, 155, 19, 25, 220, 48, 133, 117, 79, 97, 77, 43, 126, 194, 26, 248, 127, 91, 8 }, new byte[] { 0, 120, 2, 99, 22, 210, 58, 234, 136, 67, 45, 196, 13, 184, 97, 0, 195, 76, 97, 43, 73, 60, 238, 7, 102, 75, 187, 211, 20, 102, 176, 158, 138, 0, 152, 220, 159, 79, 135, 31, 28, 80, 213, 241, 115, 22, 237, 235, 220, 146, 81, 91, 241, 169, 118, 58, 64, 231, 113, 96, 121, 209, 176, 253, 84, 26, 194, 228, 247, 132, 49, 111, 200, 79, 157, 49, 167, 189, 9, 56, 57, 66, 3, 65, 222, 103, 59, 93, 144, 100, 114, 119, 119, 129, 16, 156, 40, 85, 211, 2, 237, 155, 146, 183, 210, 77, 25, 39, 56, 201, 181, 157, 214, 14, 255, 236, 200, 141, 137, 116, 181, 142, 45, 182, 17, 145, 48, 251 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("1abfc2f6-ffae-4fd1-a20f-8e84e4be080f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("57d750fa-7841-482f-beeb-171b4e5f488e") });
        }
    }
}
