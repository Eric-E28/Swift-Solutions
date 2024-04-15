using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PopNGo.Migrations
{
    /// <inheritdoc />
    public partial class AddingItineraryTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__TicketLi__3214EC272B7FA22E",
                table: "TicketLink");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Schedule__3214EC27A89D2D62",
                table: "ScheduledNotification");

            migrationBuilder.DropPrimaryKey(
                name: "PK__PG_User__3214EC2787CD8FEF",
                table: "PG_User");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Favorite__3214EC271153F6B8",
                table: "FavoriteEvents");

            migrationBuilder.DropPrimaryKey(
                name: "PK__EventHis__3214EC2713977648",
                table: "EventHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Event__3214EC27BCF71E26",
                table: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Bookmark__3214EC27B23F3CC2",
                table: "BookmarkList");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Tag__3214EC27C1BEDD99",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "ItineraryChecklistItemId",
                table: "ItineraryChecklist");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");

            migrationBuilder.RenameColumn(
                name: "AspnetuserId",
                table: "PG_User",
                newName: "ASPNETUserID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PG_User",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "FavoriteEvents",
                newName: "EventID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "FavoriteEvents",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_FavoriteEvents_EventId",
                table: "FavoriteEvents",
                newName: "IX_FavoriteEvents_EventID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "EventHistory",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "EventHistory",
                newName: "EventID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EventHistory",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_EventHistory_UserId",
                table: "EventHistory",
                newName: "IX_EventHistory_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_EventHistory_EventId",
                table: "EventHistory",
                newName: "IX_EventHistory_EventID");

            migrationBuilder.RenameColumn(
                name: "ApiEventId",
                table: "Event",
                newName: "ApiEventID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Event",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tag",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "ASPNETUserID",
                table: "PG_User",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ViewedDate",
                table: "EventHistory",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "EventImage",
                table: "Event",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApiEventID",
                table: "Event",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TextColor",
                table: "Tag",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tag",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BackgroundColor",
                table: "Tag",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK__TicketLi__3214EC27A59A429E",
                table: "TicketLink",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Schedule__3214EC275E60BD46",
                table: "ScheduledNotification",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__PG_User__3214EC279DED8B11",
                table: "PG_User",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Favorite__3214EC27747DCC93",
                table: "FavoriteEvents",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__EventHis__3214EC27FF66CD7B",
                table: "EventHistory",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Event__3214EC27ED3E79DC",
                table: "Event",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Bookmark__3214EC279FC7E8BA",
                table: "BookmarkList",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Tag__3214EC27AD0223CA",
                table: "Tag",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__TicketLi__3214EC27A59A429E",
                table: "TicketLink");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Schedule__3214EC275E60BD46",
                table: "ScheduledNotification");

            migrationBuilder.DropPrimaryKey(
                name: "PK__PG_User__3214EC279DED8B11",
                table: "PG_User");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Favorite__3214EC27747DCC93",
                table: "FavoriteEvents");

            migrationBuilder.DropPrimaryKey(
                name: "PK__EventHis__3214EC27FF66CD7B",
                table: "EventHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Event__3214EC27ED3E79DC",
                table: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Bookmark__3214EC279FC7E8BA",
                table: "BookmarkList");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Tag__3214EC27AD0223CA",
                table: "Tag");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.RenameColumn(
                name: "ASPNETUserID",
                table: "PG_User",
                newName: "AspnetuserId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PG_User",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EventID",
                table: "FavoriteEvents",
                newName: "EventId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "FavoriteEvents",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_FavoriteEvents_EventID",
                table: "FavoriteEvents",
                newName: "IX_FavoriteEvents_EventId");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "EventHistory",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "EventID",
                table: "EventHistory",
                newName: "EventId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "EventHistory",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_EventHistory_UserID",
                table: "EventHistory",
                newName: "IX_EventHistory_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_EventHistory_EventID",
                table: "EventHistory",
                newName: "IX_EventHistory_EventId");

            migrationBuilder.RenameColumn(
                name: "ApiEventID",
                table: "Event",
                newName: "ApiEventId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Event",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Tags",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "AspnetuserId",
                table: "PG_User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<int>(
                name: "ItineraryChecklistItemId",
                table: "ItineraryChecklist",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ViewedDate",
                table: "EventHistory",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "EventImage",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApiEventId",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "TextColor",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "BackgroundColor",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK__TicketLi__3214EC272B7FA22E",
                table: "TicketLink",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Schedule__3214EC27A89D2D62",
                table: "ScheduledNotification",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__PG_User__3214EC2787CD8FEF",
                table: "PG_User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Favorite__3214EC271153F6B8",
                table: "FavoriteEvents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__EventHis__3214EC2713977648",
                table: "EventHistory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Event__3214EC27BCF71E26",
                table: "Event",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Bookmark__3214EC27B23F3CC2",
                table: "BookmarkList",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Tag__3214EC27C1BEDD99",
                table: "Tags",
                column: "Id");
        }
    }
}
