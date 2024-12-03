using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LevelUP.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Achievement",
                columns: new[] { "Id", "AchievementName", "BadgeIcon", "Description", "XPRequired" },
                values: new object[,]
                {
                    { 1, "First Workout", "first_workout.png", "Complete your first workout.", 100 },
                    { 2, "Strength Master", "strength_master.png", "Complete 10 strength workouts.", 500 }
                });

            migrationBuilder.InsertData(
                table: "Quest",
                columns: new[] { "Id", "Category", "Description", "DifficultyLevel", "QuestName", "XPReward" },
                values: new object[,]
                {
                    { 1, "Cardio", "Complete your first workout!", "Easy", "Beginner's Challenge", 100 },
                    { 2, "Strength", "Complete 5 strength workouts.", "Medium", "Strength Training", 200 }
                });

            migrationBuilder.InsertData(
                table: "Reward",
                columns: new[] { "Id", "Description", "RewardName", "UnlockCriteria" },
                values: new object[,]
                {
                    { 1, "Awarded for completing 5 quests.", "Gold Medal", "Complete 5 quests." },
                    { 2, "Awarded for completing 10 workouts.", "Fitness Guru", "Complete 10 workouts." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Achievement",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Achievement",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quest",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reward",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
