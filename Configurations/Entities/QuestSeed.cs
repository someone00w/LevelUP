using Microsoft.EntityFrameworkCore;
using LevelUP.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LevelUP.Configurations.Entities
{
    public class QuestSeed : IEntityTypeConfiguration<Quest>
    {
        public void Configure(EntityTypeBuilder<Quest> builder)
        {
            builder.HasData(
                new Quest
                {
                    QuestId = 1,
                    QuestName = "D-Rank Warm-up",
                    Description = "Basic training for new hunters to improve endurance and strength.",
                    Category = "Training",
                    RankRequired = "D",  // Ensure database supports string values
                    XPReward = 100,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quest
                {
                    QuestId = 2,
                    QuestName = "Survival Instincts",
                    Description = "Increase agility and stamina to survive in low-level dungeons.",
                    Category = "Endurance",
                    RankRequired = "D",
                    XPReward = 200,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quest
                {
                    QuestId = 3,
                    QuestName = "D-Rank Power Boost",
                    Description = "Enhance strength with rigorous training.",
                    Category = "Strength",
                    RankRequired = "D",
                    XPReward = 500,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quest
                {
                    QuestId = 4,
                    QuestName = "Dungeon Sprint",
                    Description = "Improve speed and reaction time for quick escapes.",
                    Category = "Agility",
                    RankRequired = "D",
                    XPReward = 700,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quest
                {
                    QuestId = 5,
                    QuestName = "C-Rank Warrior's Test",
                    Description = "A challenging workout to prepare for higher-ranked missions.",
                    Category = "Full Body",
                    RankRequired = "C",
                    XPReward = 1200,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
