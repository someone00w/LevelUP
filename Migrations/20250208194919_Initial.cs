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
                    QuestName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RankRequired = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XPReward = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestId = table.Column<int>(type: "int", nullable: false),
                    WorkoutId = table.Column<int>(type: "int", nullable: false),
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
                    { 1, "You've started your journey as an E-Rank hunter.", "E-Rank Hunter", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5477), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5478), 0, 1, "System", 0 },
                    { 2, "Complete your first quest.", "First Blood", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5480), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5481), 1, 1, "System", 50 },
                    { 3, "Reach D-Rank by earning enough XP.", "D-Rank Awakening", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5483), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5483), 5, 2, "System", 500 },
                    { 4, "Complete 10 quests and prove your worth.", "Elite Fighter", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5485), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5485), 10, 3, "System", 1200 },
                    { 5, "Ascend to C-Rank with enough experience.", "C-Rank Promotion", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5487), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5488), 20, 4, "System", 2500 },
                    { 6, "Demonstrate your growing power by finishing 30 quests.", "Shadow Monarch's Apprentice", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5490), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5490), 30, 5, "System", 4000 },
                    { 7, "Enter the ranks of B-Rank hunters.", "B-Rank Challenger", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5492), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5492), 40, 6, "System", 6000 },
                    { 8, "Become an elite hunter by reaching A-Rank.", "A-Rank Conqueror", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5494), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5495), 50, 7, "System", 10000 },
                    { 9, "Achieve S-Rank status, the pinnacle of hunters.", "S-Rank Dominator", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5496), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5497), 75, 8, "System", 20000 },
                    { 10, "Surpass all limits and claim the title of the Shadow Monarch.", "Shadow Monarch", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5499), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5499), 100, 9, "System", 50000 }
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
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f20985ff-27d2-4bd8-92ef-559e3d8e16ce", "admin@localhost.com", true, false, null, "adminUser", "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHXcrMRd9XNtsUojL8D640wg7QzQTiZTJcMIBtUW4xgcaVV7L6mDeR1YPiE7yzw4JA==", null, false, "f5f33d72-6138-488d-8670-6f7dcc116218", false, "admin@localhost.com" },
                    { "f2c5e7a3-50fa-46d5-9bc7-1c3f09f8c6b2", 0, "debda8a6-a384-4ab4-b859-a09f86655f38", "cust@localhost.com", true, false, null, "custUser", "CUST@LOCALHOST.COM", "CUST@LOCALHOST.COM", "AQAAAAIAAYagAAAAEJS2+CivRl1mYi+cCnkzoJhSBSSN/D8pQCB1OQQ7teENaxwwgUqncK/sSeH/zrydzw==", null, false, "1105ae47-44e6-4a9f-9e89-83bb94abe55f", false, "cust@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Quest",
                columns: new[] { "QuestId", "Category", "CreatedBy", "DateCreated", "DateUpdated", "Description", "QuestName", "RankRequired", "Status", "UpdatedBy", "XPReward" },
                values: new object[,]
                {
                    { 1, "Training", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5385), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5385), "Basic training for new hunters to improve endurance and strength.", "E-Rank Warm-up", "D", "Incomplete", "System", 100 },
                    { 2, "Endurance", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5387), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5388), "Increase agility and stamina to survive in low-level dungeons.", "Survival Instincts", "D", "Incomplete", "System", 200 },
                    { 3, "Strength", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5390), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5390), "Enhance strength with rigorous training.", "D-Rank Power Boost", "D", "Incomplete", "System", 500 },
                    { 4, "Agility", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5392), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5392), "Improve speed and reaction time for quick escapes.", "Dungeon Sprint", "D", "Incomplete", "System", 700 },
                    { 5, "Full Body", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5394), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5394), "A challenging workout to prepare for higher-ranked missions.", "C-Rank Warrior's Test", "C", "Incomplete", "System", 1200 },
                    { 6, "Core", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5396), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5396), "Master balance and endurance for prolonged battles.", "B-Rank Hunter's Discipline", "C", "Incomplete", "System", 2000 },
                    { 7, "Strength", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5398), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5399), "Advanced training to develop elite hunter power.", "A-Rank Titan's Strength", "B", "Incomplete", "System", 4000 },
                    { 8, "Endurance", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5400), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5401), "Surpass your limits with extreme training.", "Shadow Monarch's Challenge", "A", "Incomplete", "System", 7000 },
                    { 9, "Full Body", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5403), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5403), "A test of skill, power, and endurance for elite hunters.", "S-Rank Battle Mastery", "S", "Incomplete", "System", 10000 },
                    { 10, "Ultimate", "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5405), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5405), "Only the strongest can complete this ultimate test.", "God of War's Training", "S", "Incomplete", "System", 20000 }
                });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "WorkoutId", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy", "WorkoutDescription", "WorkoutName" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5134), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5144), "System", "A basic upper body exercise that strengthens the chest, shoulders, and triceps.", "Push-Ups" },
                    { 2, "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5146), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5146), "System", "A lower body exercise that targets the quadriceps, hamstrings, and glutes.", "Squats" },
                    { 3, "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5148), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5148), "System", "An upper body exercise that builds back and bicep strength.", "Pull-Ups" },
                    { 4, "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5150), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5150), "System", "A core exercise that strengthens the abdominal muscles and improves endurance.", "Plank" },
                    { 5, "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5152), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5152), "System", "A lower body exercise that improves balance and strengthens the legs.", "Lunges" },
                    { 6, "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5153), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5154), "System", "A cardiovascular exercise that enhances coordination and endurance.", "Jump Rope" },
                    { 7, "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5155), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5155), "System", "A full-body exercise that combines strength and cardio training.", "Burpees" },
                    { 8, "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5157), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5157), "System", "A cardio and core workout that improves agility and endurance.", "Mountain Climbers" },
                    { 9, "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5158), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5159), "System", "A strength exercise that targets the lower back, glutes, and hamstrings.", "Deadlifts" },
                    { 10, "System", new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5160), new DateTime(2025, 2, 9, 3, 49, 19, 393, DateTimeKind.Local).AddTicks(5160), "System", "A core workout that strengthens the abdominal muscles and obliques.", "Bicycle Crunches" }
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
                table: "Staff",
                columns: new[] { "StaffId", "CreatedBy", "DateCreated", "DateUpdated", "Email", "UpdatedBy", "UserId", "UserName" },
                values: new object[] { 1, "System", new DateTime(2025, 2, 9, 3, 49, 19, 485, DateTimeKind.Local).AddTicks(4900), new DateTime(2025, 2, 9, 3, 49, 19, 485, DateTimeKind.Local).AddTicks(4917), "admin@localhost.com", "System", "3781efa7-66dc-47f0-860f-e506d04102e4", "adminUser" });

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
