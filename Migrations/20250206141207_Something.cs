using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LevelUP.Migrations
{
    /// <inheritdoc />
    public partial class Something : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quest_Workout_WorkoutId",
                table: "Quest");

            migrationBuilder.DropIndex(
                name: "IX_Quest_WorkoutId",
                table: "Quest");

            migrationBuilder.DeleteData(
                table: "Achievement",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Achievement",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Achievement",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Achievement",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Achievement",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Achievement",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Achievement",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Achievement",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Achievement",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Achievement",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "WorkoutId",
                table: "Quest");

            migrationBuilder.CreateTable(
                name: "QuestWorkout",
                columns: table => new
                {
                    QuestId = table.Column<int>(type: "int", nullable: false),
                    WorkoutId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestWorkout", x => new { x.QuestId, x.WorkoutId });
                    table.ForeignKey(
                        name: "FK_QuestWorkout_Quest_QuestId",
                        column: x => x.QuestId,
                        principalTable: "Quest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestWorkout_Workout_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workout",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestWorkout_WorkoutId",
                table: "QuestWorkout",
                column: "WorkoutId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestWorkout");

            migrationBuilder.AddColumn<int>(
                name: "WorkoutId",
                table: "Quest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Achievement",
                columns: new[] { "Id", "AchievementDescription", "AchievementName", "CreatedBy", "DateCreated", "DateUpdated", "QuestsRequired", "RankRequired", "UpdatedBy", "XPRequired" },
                values: new object[,]
                {
                    { 1, "You've started your journey as an E-Rank hunter.", "E-Rank Hunter", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, null, 0 },
                    { 2, "Complete your first quest.", "First Blood", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null, 50 },
                    { 3, "Reach D-Rank by earning enough XP.", "D-Rank Awakening", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2, null, 500 },
                    { 4, "Complete 10 quests and prove your worth.", "Elite Fighter", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 3, null, 1200 },
                    { 5, "Ascend to C-Rank with enough experience.", "C-Rank Promotion", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 4, null, 2500 },
                    { 6, "Demonstrate your growing power by finishing 30 quests.", "Shadow Monarch's Apprentice", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 5, null, 4000 },
                    { 7, "Enter the ranks of B-Rank hunters.", "B-Rank Challenger", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 6, null, 6000 },
                    { 8, "Become an elite hunter by reaching A-Rank.", "A-Rank Conqueror", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 7, null, 10000 },
                    { 9, "Achieve S-Rank status, the pinnacle of hunters.", "S-Rank Dominator", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, 8, null, 20000 },
                    { 10, "Surpass all limits and claim the title of the Shadow Monarch.", "Shadow Monarch", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 9, null, 50000 }
                });

            migrationBuilder.UpdateData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 1,
                column: "WorkoutId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 2,
                column: "WorkoutId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 3,
                column: "WorkoutId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Quest",
                columns: new[] { "Id", "Category", "CreatedBy", "DateCreated", "DateUpdated", "Description", "QuestName", "RankRequired", "UpdatedBy", "WorkoutId", "XPReward" },
                values: new object[,]
                {
                    { 4, "Agility", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Improve speed and reaction time for quick escapes.", "Dungeon Sprint", "D", null, 8, 700 },
                    { 5, "Full Body", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A challenging workout to prepare for higher-ranked missions.", "C-Rank Warrior's Test", "C", null, 7, 1200 },
                    { 6, "Core", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master balance and endurance for prolonged battles.", "B-Rank Hunter's Discipline", "B", null, 4, 2000 },
                    { 7, "Strength", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Advanced training to develop elite hunter power.", "A-Rank Titan's Strength", "A", null, 9, 4000 },
                    { 8, "Endurance", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Surpass your limits with extreme training.", "Shadow Monarch's Challenge", "S", null, 5, 7000 },
                    { 9, "Full Body", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A test of skill, power, and endurance for elite hunters.", "S-Rank Battle Mastery", "S", null, 3, 10000 },
                    { 10, "Ultimate", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Only the strongest can complete this ultimate test.", "God of War's Training", "SS", null, 10, 20000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quest_WorkoutId",
                table: "Quest",
                column: "WorkoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quest_Workout_WorkoutId",
                table: "Quest",
                column: "WorkoutId",
                principalTable: "Workout",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
