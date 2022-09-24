using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Codebeutel.API.Migrations
{
    public partial class AddSentNotificationToSuggested : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedDispenserApproval_SuggestedDispenser_SuggestedDisp~",
                table: "SuggestedDispenserApproval");

            migrationBuilder.DropColumn(
                name: "SuggestedDispensersId",
                table: "SuggestedDispenserApproval");

            migrationBuilder.AlterColumn<int>(
                name: "SuggestedDispenserId",
                table: "SuggestedDispenserApproval",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SuggestedDispenser",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<bool>(
                name: "NotificationSent",
                table: "SuggestedDispenser",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "DogFriendlyPlace",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedDispenserApproval_SuggestedDispenser_SuggestedDisp~",
                table: "SuggestedDispenserApproval",
                column: "SuggestedDispenserId",
                principalTable: "SuggestedDispenser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedDispenserApproval_SuggestedDispenser_SuggestedDisp~",
                table: "SuggestedDispenserApproval");

            migrationBuilder.DropColumn(
                name: "NotificationSent",
                table: "SuggestedDispenser");

            migrationBuilder.AlterColumn<int>(
                name: "SuggestedDispenserId",
                table: "SuggestedDispenserApproval",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "SuggestedDispensersId",
                table: "SuggestedDispenserApproval",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SuggestedDispenser",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "DogFriendlyPlace",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedDispenserApproval_SuggestedDispenser_SuggestedDisp~",
                table: "SuggestedDispenserApproval",
                column: "SuggestedDispenserId",
                principalTable: "SuggestedDispenser",
                principalColumn: "Id");
        }
    }
}
