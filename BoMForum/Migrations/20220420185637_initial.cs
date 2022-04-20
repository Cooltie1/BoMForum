using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BoMForum.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TagText = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagID);
                });

            migrationBuilder.CreateTable(
                name: "UserPosts",
                columns: table => new
                {
                    UserPostID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserPostText = table.Column<string>(nullable: false),
                    UserPostTitle = table.Column<string>(nullable: false),
                    TagID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPosts", x => x.UserPostID);
                    table.ForeignKey(
                        name: "FK_UserPosts_Tags_TagID",
                        column: x => x.TagID,
                        principalTable: "Tags",
                        principalColumn: "TagID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommentText = table.Column<string>(nullable: true),
                    CommentDate = table.Column<DateTime>(nullable: false),
                    Likes = table.Column<int>(nullable: false),
                    UserPostID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_UserPosts_UserPostID",
                        column: x => x.UserPostID,
                        principalTable: "UserPosts",
                        principalColumn: "UserPostID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 1, "Atonement" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 18, "Prophets" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 17, "Humility" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 16, "Temples" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 15, "Covenants" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 14, "Family" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 13, "Priesthood" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 12, "Holy Ghost" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 11, "Baptism" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 10, "Repentence" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 9, "Faith" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 8, "Tithing" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 7, "Law of Chastity" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 6, "Word of Wisdom" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 5, "Testimony" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 4, "Question" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 3, "Godhead" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 2, "Missionary Work" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 19, "Hardships and Challenges" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagText" },
                values: new object[] { 20, "The Church" });

            migrationBuilder.InsertData(
                table: "UserPosts",
                columns: new[] { "UserPostID", "TagID", "UserPostText", "UserPostTitle" },
                values: new object[] { 1, 1, "Lorem ipsumLorem ipsumLorem ipsumLorem ipsumLorem ipsumLorem ipsumLorem ipsumLorem ipsumLorem ipsumLorem ipsumLorem ipsum", "Example Post" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserPostID",
                table: "Comments",
                column: "UserPostID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPosts_TagID",
                table: "UserPosts",
                column: "TagID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "UserPosts");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
