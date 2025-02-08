using Microsoft.EntityFrameworkCore;
using LevelUP.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LevelUP.Configurations.Entities
{
    public class AchievementSeed : IEntityTypeConfiguration<Achievement>
    {
        public void Configure(EntityTypeBuilder<Achievement> builder)
        {
            builder.HasData(
                new Achievement
                {
                    AchievementId = 1,
                    AchievementName = "E-Rank Hunter",
                    AchievementDescription = "You've started your journey as an E-Rank hunter.",
                    XPRequired = 0,
                    QuestsRequired = 0,
                    RankRequired = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Achievement
                {
                    AchievementId = 2,
                    AchievementName = "First Blood",
                    AchievementDescription = "Complete your first quest.",
                    XPRequired = 50,
                    QuestsRequired = 1,
                    RankRequired = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Achievement
                {
                    AchievementId = 3,
                    AchievementName = "D-Rank Awakening",
                    AchievementDescription = "Reach D-Rank by earning enough XP.",
                    XPRequired = 500,
                    QuestsRequired = 5,
                    RankRequired = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Achievement
                {
                    AchievementId = 4,
                    AchievementName = "Elite Fighter",
                    AchievementDescription = "Complete 10 quests and prove your worth.",
                    XPRequired = 1200,
                    QuestsRequired = 10,
                    RankRequired = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Achievement
                {
                    AchievementId = 5,
                    AchievementName = "C-Rank Promotion",
                    AchievementDescription = "Ascend to C-Rank with enough experience.",
                    XPRequired = 2500,
                    QuestsRequired = 20,
                    RankRequired = 4,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Achievement
                {
                    AchievementId = 6,
                    AchievementName = "Shadow Monarch's Apprentice",
                    AchievementDescription = "Demonstrate your growing power by finishing 30 quests.",
                    XPRequired = 4000,
                    QuestsRequired = 30,
                    RankRequired = 5,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Achievement
                {
                    AchievementId = 7,
                    AchievementName = "B-Rank Challenger",
                    AchievementDescription = "Enter the ranks of B-Rank hunters.",
                    XPRequired = 6000,
                    QuestsRequired = 40,
                    RankRequired = 6,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Achievement
                {
                    AchievementId = 8,
                    AchievementName = "A-Rank Conqueror",
                    AchievementDescription = "Become an elite hunter by reaching A-Rank.",
                    XPRequired = 10000,
                    QuestsRequired = 50,
                    RankRequired = 7,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Achievement
                {
                    AchievementId = 9,
                    AchievementName = "S-Rank Dominator",
                    AchievementDescription = "Achieve S-Rank status, the pinnacle of hunters.",
                    XPRequired = 20000,
                    QuestsRequired = 75,
                    RankRequired = 8,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Achievement
                {
                    AchievementId = 10,
                    AchievementName = "Shadow Monarch",
                    AchievementDescription = "Surpass all limits and claim the title of the Shadow Monarch.",
                    XPRequired = 50000,
                    QuestsRequired = 100,
                    RankRequired = 9,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}