using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LevelUP.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievement",
                columns: table => new
                {
                    AchievementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AchievementName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AchievementDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XPRequired = table.Column<int>(type: "int", nullable: true),
                    QuestsRequired = table.Column<int>(type: "int", nullable: true),
                    RankRequired = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievement", x => x.AchievementId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quest",
                columns: table => new
                {
                    QuestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XPReward = table.Column<int>(type: "int", nullable: false),
                    RankRequired = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quest", x => x.QuestId);
                });

            migrationBuilder.CreateTable(
                name: "Workout",
                columns: table => new
                {
                    WorkoutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkoutDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workout", x => x.WorkoutId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XPAmount = table.Column<int>(type: "int", nullable: false),
                    Rank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customer_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                    table.ForeignKey(
                        name: "FK_Staff_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "QuestWorkout",
                columns: table => new
                {
                    QuestWorkoutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestId = table.Column<int>(type: "int", nullable: false),
                    WorkoutId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestId1 = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestWorkout", x => x.QuestWorkoutId);
                    table.ForeignKey(
                        name: "FK_QuestWorkout_Quest_QuestId",
                        column: x => x.QuestId,
                        principalTable: "Quest",
                        principalColumn: "QuestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestWorkout_Quest_QuestId1",
                        column: x => x.QuestId1,
                        principalTable: "Quest",
                        principalColumn: "QuestId");
                    table.ForeignKey(
                        name: "FK_QuestWorkout_Workout_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workout",
                        principalColumn: "WorkoutId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAchievement",
                columns: table => new
                {
                    UserAchievementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateUnlocked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    AchievementId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAchievement", x => x.UserAchievementId);
                    table.ForeignKey(
                        name: "FK_UserAchievement_Achievement_AchievementId",
                        column: x => x.AchievementId,
                        principalTable: "Achievement",
                        principalColumn: "AchievementId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAchievement_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserQuest",
                columns: table => new
                {
                    UserQuestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    QuestId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserQuest", x => x.UserQuestId);
                    table.ForeignKey(
                        name: "FK_UserQuest_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserQuest_Quest_QuestId",
                        column: x => x.QuestId,
                        principalTable: "Quest",
                        principalColumn: "QuestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Achievement",
                columns: new[] { "AchievementId", "AchievementDescription", "AchievementName", "CreatedBy", "DateCreated", "DateUpdated", "QuestsRequired", "RankRequired", "UpdatedBy", "XPRequired" },
                values: new object[,]
                {
                    { 1, "You've started your journey as an E-Rank hunter.", "E-Rank Hunter", "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5589), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5589), 0, 1, "System", 0 },
                    { 2, "Complete your first quest.", "First Blood", "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5592), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5592), 1, 1, "System", 50 },
                    { 3, "Reach D-Rank by earning enough XP.", "D-Rank Awakening", "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5594), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5595), 5, 2, "System", 500 },
                    { 4, "Complete 10 quests and prove your worth.", "Elite Fighter", "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5597), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5597), 10, 3, "System", 1200 },
                    { 5, "Ascend to C-Rank with enough experience.", "C-Rank Promotion", "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5599), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5600), 20, 4, "System", 2500 },
                    { 6, "Demonstrate your growing power by finishing 30 quests.", "Shadow Monarch's Apprentice", "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5602), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5602), 30, 5, "System", 4000 },
                    { 7, "Enter the ranks of B-Rank hunters.", "B-Rank Challenger", "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5604), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5605), 40, 6, "System", 6000 },
                    { 8, "Become an elite hunter by reaching A-Rank.", "A-Rank Conqueror", "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5607), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5607), 50, 7, "System", 10000 },
                    { 9, "Achieve S-Rank status, the pinnacle of hunters.", "S-Rank Dominator", "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5609), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5609), 75, 8, "System", 20000 },
                    { 10, "Surpass all limits and claim the title of the Shadow Monarch.", "Shadow Monarch", "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5611), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5612), 100, 9, "System", 50000 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" },
                    { "cd2bcf0c-20db-474f-8407-5a6b159518bc", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "fdfb1c6a-b540-475a-ad93-e3e225503f8d", "admin@localhost.com", true, false, null, "adminUser", "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEoKFqC50aqemhs9KNXeYH7ZkHG7InjZpXk8cuVIE9DNbivsGSAXkDjssaoNgplCyA==", null, false, "591a4869-df07-4beb-8b6f-add2487e6ee8", false, "admin@localhost.com" },
                    { "f2c5e7a3-50fa-46d5-9bc7-1c3f09f8c6b2", 0, "cae30d03-10f5-4a1e-8099-dac4047efb05", "cust@localhost.com", true, false, null, "custUser", "CUST@LOCALHOST.COM", "CUST@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEvMJMb2A3G0aqqNYjlZRy+TH+oZsDF0KYXc+pnS9loZ3Eo7ZHVj/4JS13cBq5c4bg==", null, false, "f499d169-8540-4471-89b4-a9c8d30f9d27", false, "cust@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Quest",
                columns: new[] { "QuestId", "Category", "CreatedBy", "DateCreated", "DateUpdated", "Description", "QuestName", "RankRequired", "UpdatedBy", "XPReward" },
                values: new object[,]
                {
                    { 1, "Training", "System", new DateTime(2025, 2, 9, 9, 6, 42, 393, DateTimeKind.Utc).AddTicks(5338), new DateTime(2025, 2, 9, 9, 6, 42, 393, DateTimeKind.Utc).AddTicks(5339), "Basic training for new hunters to improve endurance and strength.", "D-Rank Warm-up", "D", "System", 100 },
                    { 2, "Endurance", "System", new DateTime(2025, 2, 9, 9, 6, 42, 393, DateTimeKind.Utc).AddTicks(5341), new DateTime(2025, 2, 9, 9, 6, 42, 393, DateTimeKind.Utc).AddTicks(5342), "Increase agility and stamina to survive in low-level dungeons.", "Survival Instincts", "D", "System", 200 },
                    { 3, "Strength", "System", new DateTime(2025, 2, 9, 9, 6, 42, 393, DateTimeKind.Utc).AddTicks(5344), new DateTime(2025, 2, 9, 9, 6, 42, 393, DateTimeKind.Utc).AddTicks(5344), "Enhance strength with rigorous training.", "D-Rank Power Boost", "D", "System", 500 },
                    { 4, "Agility", "System", new DateTime(2025, 2, 9, 9, 6, 42, 393, DateTimeKind.Utc).AddTicks(5346), new DateTime(2025, 2, 9, 9, 6, 42, 393, DateTimeKind.Utc).AddTicks(5346), "Improve speed and reaction time for quick escapes.", "Dungeon Sprint", "D", "System", 700 },
                    { 5, "Full Body", "System", new DateTime(2025, 2, 9, 9, 6, 42, 393, DateTimeKind.Utc).AddTicks(5348), new DateTime(2025, 2, 9, 9, 6, 42, 393, DateTimeKind.Utc).AddTicks(5349), "A challenging workout to prepare for higher-ranked missions.", "C-Rank Warrior's Test", "C", "System", 1200 }
                });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "WorkoutId", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy", "WorkoutDescription", "WorkoutName" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5068), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5081), "System", "A basic upper body exercise that strengthens the chest, shoulders, and triceps.", "Push-Ups" },
                    { 2, "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5084), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5085), "System", "A lower body exercise that targets the quadriceps, hamstrings, and glutes.", "Squats" },
                    { 3, "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5086), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5087), "System", "An upper body exercise that builds back and bicep strength.", "Pull-Ups" },
                    { 4, "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5088), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5089), "System", "A core exercise that strengthens the abdominal muscles and improves endurance.", "Plank" },
                    { 5, "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5090), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5091), "System", "A lower body exercise that improves balance and strengthens the legs.", "Lunges" },
                    { 6, "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5092), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5092), "System", "A cardiovascular exercise that enhances coordination and endurance.", "Jump Rope" },
                    { 7, "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5094), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5094), "System", "A full-body exercise that combines strength and cardio training.", "Burpees" },
                    { 8, "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5096), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5096), "System", "A cardio and core workout that improves agility and endurance.", "Mountain Climbers" },
                    { 9, "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5097), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5098), "System", "A strength exercise that targets the lower back, glutes, and hamstrings.", "Deadlifts" },
                    { 10, "System", new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5099), new DateTime(2025, 2, 9, 17, 6, 42, 393, DateTimeKind.Local).AddTicks(5100), "System", "A core workout that strengthens the abdominal muscles and obliques.", "Bicycle Crunches" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "cd2bcf0c-20db-474f-8407-5a6b159518bc", "f2c5e7a3-50fa-46d5-9bc7-1c3f09f8c6b2" }
                });

            migrationBuilder.InsertData(
                table: "QuestWorkout",
                columns: new[] { "QuestWorkoutId", "CreatedBy", "DateCreated", "DateUpdated", "QuestId", "QuestId1", "Status", "UpdatedBy", "WorkoutId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Incomplete", null, 1 },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Incomplete", null, 2 },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Incomplete", null, 6 },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Incomplete", null, 8 },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Incomplete", null, 7 },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Incomplete", null, 3 },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Incomplete", null, 9 },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "Incomplete", null, 6 },
                    { 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "Incomplete", null, 10 },
                    { 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, "Incomplete", null, 1 },
                    { 11, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, "Incomplete", null, 2 },
                    { 12, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, "Incomplete", null, 9 }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffId", "CreatedBy", "DateCreated", "DateUpdated", "Email", "UpdatedBy", "UserId", "UserName" },
                values: new object[] { 1, "System", new DateTime(2025, 2, 9, 17, 6, 42, 502, DateTimeKind.Local).AddTicks(1683), new DateTime(2025, 2, 9, 17, 6, 42, 502, DateTimeKind.Local).AddTicks(1704), "admin@localhost.com", "System", "3781efa7-66dc-47f0-860f-e506d04102e4", "adminUser" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_UserId",
                table: "Customer",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestWorkout_QuestId",
                table: "QuestWorkout",
                column: "QuestId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestWorkout_QuestId1",
                table: "QuestWorkout",
                column: "QuestId1");

            migrationBuilder.CreateIndex(
                name: "IX_QuestWorkout_WorkoutId",
                table: "QuestWorkout",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_UserId",
                table: "Staff",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievement_AchievementId",
                table: "UserAchievement",
                column: "AchievementId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievement_CustomerId",
                table: "UserAchievement",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuest_CustomerId",
                table: "UserQuest",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuest_QuestId",
                table: "UserQuest",
                column: "QuestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "QuestWorkout");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "UserAchievement");

            migrationBuilder.DropTable(
                name: "UserQuest");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Workout");

            migrationBuilder.DropTable(
                name: "Achievement");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Quest");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
