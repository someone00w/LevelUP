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
                    QuestName = "E-Rank Warm-up",
                    Description = "Basic training for new hunters to improve endurance and strength.",
                    Category = "Training",
                    RankRequired = "D",
                    XPReward = 100,
                    Status = "Incomplete",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
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
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
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
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
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
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
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
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quest
                {
                    QuestId = 6,
                    QuestName = "B-Rank Hunter's Discipline",
                    Description = "Master balance and endurance for prolonged battles.",
                    Category = "Core",
                    RankRequired = "C",
                    XPReward = 2000,
                    Status = "Incomplete",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quest
                {
                    QuestId = 7,
                    QuestName = "A-Rank Titan's Strength",
                    Description = "Advanced training to develop elite hunter power.",
                    Category = "Strength",
                    RankRequired = "B",
                    XPReward = 4000,
                    Status = "Incomplete",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quest
                {
                    QuestId = 8,
                    QuestName = "Shadow Monarch's Challenge",
                    Description = "Surpass your limits with extreme training.",
                    Category = "Endurance",
                    RankRequired = "A",
                    XPReward = 7000,
                    Status = "Incomplete",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quest
                {
                    QuestId = 9,
                    QuestName = "S-Rank Battle Mastery",
                    Description = "A test of skill, power, and endurance for elite hunters.",
                    Category = "Full Body",
                    RankRequired = "S",
                    XPReward = 10000,
                    Status = "Incomplete",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quest
                {
                    QuestId = 10,
                    QuestName = "God of War's Training",
                    Description = "Only the strongest can complete this ultimate test.",
                    Category = "Ultimate",
                    RankRequired = "S",
                    XPReward = 20000,
                    Status = "Incomplete",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}