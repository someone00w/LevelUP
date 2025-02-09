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
                    { 1, "You've started your journey as an E-Rank hunter.", "E-Rank Hunter", "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4067), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4067), 0, 1, "System", 0 },
                    { 2, "Complete your first quest.", "First Blood", "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4070), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4070), 1, 1, "System", 50 },
                    { 3, "Reach D-Rank by earning enough XP.", "D-Rank Awakening", "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4072), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4072), 5, 2, "System", 500 },
                    { 4, "Complete 10 quests and prove your worth.", "Elite Fighter", "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4074), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4075), 10, 3, "System", 1200 },
                    { 5, "Ascend to C-Rank with enough experience.", "C-Rank Promotion", "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4076), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4077), 20, 4, "System", 2500 },
                    { 6, "Demonstrate your growing power by finishing 30 quests.", "Shadow Monarch's Apprentice", "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4079), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4079), 30, 5, "System", 4000 },
                    { 7, "Enter the ranks of B-Rank hunters.", "B-Rank Challenger", "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4081), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4081), 40, 6, "System", 6000 },
                    { 8, "Become an elite hunter by reaching A-Rank.", "A-Rank Conqueror", "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4083), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4084), 50, 7, "System", 10000 },
                    { 9, "Achieve S-Rank status, the pinnacle of hunters.", "S-Rank Dominator", "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4085), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4086), 75, 8, "System", 20000 },
                    { 10, "Surpass all limits and claim the title of the Shadow Monarch.", "Shadow Monarch", "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4088), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(4088), 100, 9, "System", 50000 }
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
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "4fee9286-6f53-4e4a-9b50-34a60691339a", "admin@localhost.com", true, false, null, "adminUser", "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEP7h1T/vnfRRfBEvEpJM+DkgQYl2VTHKVKqi62TWj/jBKagcWikY9/vBFmG0F4BDjQ==", null, false, "c9a1bbb0-fd80-43ef-aab1-7db2d7ec4126", false, "admin@localhost.com" },
                    { "f2c5e7a3-50fa-46d5-9bc7-1c3f09f8c6b2", 0, "f7ce9770-5321-4c79-bec2-f08e21f1dd81", "cust@localhost.com", true, false, null, "custUser", "CUST@LOCALHOST.COM", "CUST@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIhkWYNHbmP2XmKyVgGXbak/v4gNd5ru0DJxB24KBivxgaliAFdhwZEvQwV3weyf0Q==", null, false, "0936c8ef-ff0c-482c-add7-b708deb40b88", false, "cust@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Quest",
                columns: new[] { "QuestId", "Category", "CreatedBy", "DateCreated", "DateUpdated", "Description", "QuestName", "RankRequired", "UpdatedBy", "XPReward" },
                values: new object[,]
                {
                    { 1, "Training", "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3827), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3827), "Basic training for new hunters to improve endurance and strength.", "D-Rank Warm-up", "D", "System", 100 },
                    { 2, "Endurance", "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3829), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3830), "Increase agility and stamina to survive in low-level dungeons.", "Survival Instincts", "D", "System", 200 },
                    { 3, "Strength", "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3832), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3832), "Enhance strength with rigorous training.", "D-Rank Power Boost", "D", "System", 500 },
                    { 4, "Agility", "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3834), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3834), "Improve speed and reaction time for quick escapes.", "Dungeon Sprint", "D", "System", 700 },
                    { 5, "Full Body", "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3835), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3836), "A challenging workout to prepare for higher-ranked missions.", "C-Rank Warrior's Test", "C", "System", 1200 },
                    { 6, "Combat", "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3837), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3838), "Advanced combat training to prepare for elite-level battles.", "B-Rank Combat Mastery", "B", "System", 2500 },
                    { 7, "Exploration", "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3840), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3840), "Navigate through dungeons to master terrain and encounter dangerous creatures.", "Dungeon Explorer", "B", "System", 3000 },
                    { 8, "Boss Fight", "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3841), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3842), "Test your abilities against the strongest foes in the world.", "A-Rank Hero's Challenge", "A", "System", 5000 },
                    { 9, "Ultimate", "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3843), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3844), "A trial to become the greatest warrior, battling ancient and powerful foes.", "S-Rank Immortal's Trial", "S", "System", 10000 },
                    { 10, "Race", "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3845), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3846), "A timed race that tests the hunter’s agility, speed, and endurance.", "Speedster's Run", "D", "System", 600 }
                });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "WorkoutId", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy", "WorkoutDescription", "WorkoutName" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3625), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3636), "System", "A basic upper body exercise that strengthens the chest, shoulders, and triceps.", "Push-Ups" },
                    { 2, "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3638), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3639), "System", "A lower body exercise that targets the quadriceps, hamstrings, and glutes.", "Squats" },
                    { 3, "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3641), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3641), "System", "An upper body exercise that builds back and bicep strength.", "Pull-Ups" },
                    { 4, "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3642), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3643), "System", "A core exercise that strengthens the abdominal muscles and improves endurance.", "Plank" },
                    { 5, "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3644), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3645), "System", "A lower body exercise that improves balance and strengthens the legs.", "Lunges" },
                    { 6, "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3646), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3646), "System", "A cardiovascular exercise that enhances coordination and endurance.", "Jump Rope" },
                    { 7, "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3647), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3648), "System", "A full-body exercise that combines strength and cardio training.", "Burpees" },
                    { 8, "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3649), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3650), "System", "A cardio and core workout that improves agility and endurance.", "Mountain Climbers" },
                    { 9, "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3651), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3652), "System", "A strength exercise that targets the lower back, glutes, and hamstrings.", "Deadlifts" },
                    { 10, "System", new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3653), new DateTime(2025, 2, 9, 22, 50, 21, 488, DateTimeKind.Local).AddTicks(3653), "System", "A core workout that strengthens the abdominal muscles and obliques.", "Bicycle Crunches" }
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
                    { 1, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3920), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3921), 1, null, "Incomplete", "System", 1 },
                    { 2, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3922), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3923), 1, null, "Incomplete", "System", 2 },
                    { 3, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3924), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3925), 1, null, "Incomplete", "System", 6 },
                    { 4, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3926), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3926), 2, null, "Incomplete", "System", 8 },
                    { 5, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3927), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3928), 2, null, "Incomplete", "System", 7 },
                    { 6, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3929), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3929), 3, null, "Incomplete", "System", 3 },
                    { 7, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3931), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3931), 3, null, "Incomplete", "System", 9 },
                    { 8, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3932), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3933), 4, null, "Incomplete", "System", 6 },
                    { 9, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3960), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3961), 4, null, "Incomplete", "System", 10 },
                    { 10, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3962), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3963), 5, null, "Incomplete", "System", 1 },
                    { 11, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3964), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3964), 5, null, "Incomplete", "System", 2 },
                    { 12, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3966), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3966), 5, null, "Incomplete", "System", 9 },
                    { 13, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3967), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3968), 6, null, "Incomplete", "System", 4 },
                    { 14, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3969), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3969), 6, null, "Incomplete", "System", 5 },
                    { 15, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3971), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3971), 6, null, "Incomplete", "System", 7 },
                    { 16, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3972), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3973), 7, null, "Incomplete", "System", 8 },
                    { 17, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3974), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3974), 7, null, "Incomplete", "System", 10 },
                    { 18, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3976), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3976), 8, null, "Incomplete", "System", 1 },
                    { 19, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3977), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3978), 8, null, "Incomplete", "System", 3 },
                    { 20, "System", new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3979), new DateTime(2025, 2, 9, 14, 50, 21, 488, DateTimeKind.Utc).AddTicks(3979), 8, null, "Incomplete", "System", 6 }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffId", "CreatedBy", "DateCreated", "DateUpdated", "Email", "UpdatedBy", "UserId", "UserName" },
                values: new object[] { 1, "System", new DateTime(2025, 2, 9, 22, 50, 21, 585, DateTimeKind.Local).AddTicks(7340), new DateTime(2025, 2, 9, 22, 50, 21, 585, DateTimeKind.Local).AddTicks(7353), "admin@localhost.com", "System", "3781efa7-66dc-47f0-860f-e506d04102e4", "adminUser" });

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
