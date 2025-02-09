using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LevelUP.Migrations
{
    /// <inheritdoc />
    public partial class Something : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2942), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2948), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2952), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2955), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2959), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2963), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2967), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2970), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2974), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(3030), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6f13d6b-c993-4add-91e2-aaae0faac888", "AQAAAAIAAYagAAAAEJtGk7fgmgo3/FQ8kS6/YjzisNoG+Q8p2aD4tK3BbSlIdr0fUJkEN28BA0h6uLByrw==", "db67bd22-2072-4f67-b921-f959189e5138" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2c5e7a3-50fa-46d5-9bc7-1c3f09f8c6b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4416d66-f319-4cbe-923c-78a3ac752ac3", "AQAAAAIAAYagAAAAEM37BLdi2VPzu/uew6aJNemi29V4grWtR1cN3FIApI8VRaL0FoDBrOClOz+RJq4q0Q==", "38507989-41f0-429d-986b-12fd5f464876" });

            migrationBuilder.UpdateData(
                table: "Quest",
                keyColumn: "QuestId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 9, 16, 36, 573, DateTimeKind.Utc).AddTicks(2694), new DateTime(2025, 2, 9, 9, 16, 36, 573, DateTimeKind.Utc).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "Quest",
                keyColumn: "QuestId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 9, 16, 36, 573, DateTimeKind.Utc).AddTicks(2698), new DateTime(2025, 2, 9, 9, 16, 36, 573, DateTimeKind.Utc).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Quest",
                keyColumn: "QuestId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 9, 16, 36, 573, DateTimeKind.Utc).AddTicks(2702), new DateTime(2025, 2, 9, 9, 16, 36, 573, DateTimeKind.Utc).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "Quest",
                keyColumn: "QuestId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 9, 16, 36, 573, DateTimeKind.Utc).AddTicks(2705), new DateTime(2025, 2, 9, 9, 16, 36, 573, DateTimeKind.Utc).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "Quest",
                keyColumn: "QuestId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 9, 16, 36, 573, DateTimeKind.Utc).AddTicks(2708), new DateTime(2025, 2, 9, 9, 16, 36, 573, DateTimeKind.Utc).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 731, DateTimeKind.Local).AddTicks(6291), new DateTime(2025, 2, 9, 17, 16, 36, 731, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2375), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2396), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2400), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2403), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2406), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2408), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2411), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2414), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2417), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2420), new DateTime(2025, 2, 9, 17, 16, 36, 573, DateTimeKind.Local).AddTicks(2420) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(489), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(494), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(497), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(500), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(503), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(506), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(509), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(512), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(516), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "AchievementId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(519), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5edfae8f-5cea-485e-b9aa-69e3d1de17cc", "AQAAAAIAAYagAAAAEEo/aA82mqxMZIxk3iAkivSTnDqjchwx2UXEEb1u84DzFFn+UIgiThWUQNOyFi0XPw==", "8ef9de17-c55c-4f07-b5ab-4fff20b06d53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2c5e7a3-50fa-46d5-9bc7-1c3f09f8c6b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5e9a0ed-f8f7-4c94-9a17-a31c04cc7e43", "AQAAAAIAAYagAAAAEL2A13XAiqPCO51J+CA8xfqB3INbjHi2I2FhidMFU6/7OQ6vA5IhCokcNxwB32cV3w==", "fd99fc13-f0f3-43e2-808a-a0cc9bbe1025" });

            migrationBuilder.UpdateData(
                table: "Quest",
                keyColumn: "QuestId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 9, 14, 48, 322, DateTimeKind.Utc).AddTicks(272), new DateTime(2025, 2, 9, 9, 14, 48, 322, DateTimeKind.Utc).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Quest",
                keyColumn: "QuestId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 9, 14, 48, 322, DateTimeKind.Utc).AddTicks(276), new DateTime(2025, 2, 9, 9, 14, 48, 322, DateTimeKind.Utc).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Quest",
                keyColumn: "QuestId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 9, 14, 48, 322, DateTimeKind.Utc).AddTicks(279), new DateTime(2025, 2, 9, 9, 14, 48, 322, DateTimeKind.Utc).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Quest",
                keyColumn: "QuestId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 9, 14, 48, 322, DateTimeKind.Utc).AddTicks(282), new DateTime(2025, 2, 9, 9, 14, 48, 322, DateTimeKind.Utc).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Quest",
                keyColumn: "QuestId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 9, 14, 48, 322, DateTimeKind.Utc).AddTicks(285), new DateTime(2025, 2, 9, 9, 14, 48, 322, DateTimeKind.Utc).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 458, DateTimeKind.Local).AddTicks(3286), new DateTime(2025, 2, 9, 17, 14, 48, 458, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 321, DateTimeKind.Local).AddTicks(9988), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(7), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(9), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(12), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(14), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(16), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(19), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(21), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(24), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "WorkoutId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(26), new DateTime(2025, 2, 9, 17, 14, 48, 322, DateTimeKind.Local).AddTicks(26) });
        }
    }
}
