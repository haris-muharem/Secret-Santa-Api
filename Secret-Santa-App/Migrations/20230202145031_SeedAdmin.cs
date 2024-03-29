﻿// <auto-generated>
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Secret_Santa_App.Migrations
{
    public partial class SeedAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "GiftRecepientId", "LastName", "PasswordHash", "PasswordSalt", "RecepientFullName", "UserRole" },
                values: new object[] { 1, "harisbegic01@hotmail.com", "Haris", null, "Begic", new byte[] { 213, 190, 140, 108, 138, 8, 231, 62, 87, 64, 216, 246, 251, 117, 254, 140, 48, 134, 212, 148, 28, 199, 230, 235, 113, 108, 14, 123, 250, 189, 116, 20, 15, 14, 13, 146, 135, 167, 248, 162, 73, 111, 178, 19, 188, 25, 140, 220, 37, 123, 198, 113, 183, 94, 19, 246, 88, 86, 13, 150, 118, 2, 31, 230 }, new byte[] { 159, 252, 68, 141, 19, 232, 250, 56, 15, 136, 115, 143, 191, 216, 69, 6, 151, 165, 61, 226, 106, 4, 251, 23, 191, 231, 233, 224, 160, 249, 169, 15, 249, 9, 20, 4, 39, 38, 69, 230, 59, 138, 214, 86, 218, 51, 202, 162, 201, 184, 178, 188, 226, 99, 164, 34, 35, 125, 212, 210, 206, 118, 119, 193, 58, 17, 171, 225, 192, 225, 146, 222, 14, 124, 93, 78, 44, 80, 40, 139, 230, 118, 37, 75, 107, 73, 88, 250, 184, 208, 243, 214, 109, 98, 78, 175, 196, 2, 25, 184, 181, 191, 116, 157, 38, 77, 108, 220, 163, 231, 163, 194, 252, 218, 141, 62, 95, 22, 28, 30, 231, 152, 139, 114, 239, 39, 49, 58 }, null, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
