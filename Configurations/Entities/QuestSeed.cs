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
                QuestName = "Awakening Ritual",
                Description = "A basic endurance test for new hunters to awaken their hidden potential.",
                Category = "Endurance",
                RankRequired = "D",
                XPReward = 100,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Quest
            {
                QuestId = 2,
                QuestName = "Sprint Through the Dungeon",
                Description = "Dodge traps and escape from low-tier beasts while building agility.",
                Category = "Agility",
                RankRequired = "D",
                XPReward = 200,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Quest
            {
                QuestId = 3,
                QuestName = "Strength of a Tank",
                Description = "Lift heavy equipment and battle low-rank dungeon golems to increase raw power.",
                Category = "Strength",
                RankRequired = "D",
                XPReward = 500,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Quest
            {
                QuestId = 4,
                QuestName = "Phantom Step Training",
                Description = "Master dodging techniques and reaction speed to evade attacks from dungeon monsters.",
                Category = "Agility",
                RankRequired = "D",
                XPReward = 700,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Quest
            {
                QuestId = 5,
                QuestName = "C-Rank Ascension Trial",
                Description = "Face tougher dungeon monsters and push past your physical limits.",
                Category = "Full Body",
                RankRequired = "C",
                XPReward = 1200,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Quest
            {
                QuestId = 6,
                QuestName = "Berserker’s Combat Drill",
                Description = "Simulated battle scenarios to refine combat reflexes and endurance.",
                Category = "Combat",
                RankRequired = "B",
                XPReward = 2500,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Quest
            {
                QuestId = 7,
                QuestName = "Dungeon Explorer’s Gauntlet",
                Description = "Navigate through high-risk dungeons, testing endurance and adaptability.",
                Category = "Exploration",
                RankRequired = "B",
                XPReward = 3000,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Quest
            {
                QuestId = 8,
                QuestName = "A-Rank Hero’s Gauntlet",
                Description = "Engage in high-intensity training to prepare for S-rank missions.",
                Category = "Boss Fight",
                RankRequired = "A",
                XPReward = 5000,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Quest
            {
                QuestId = 9,
                QuestName = "S-Rank Titan's Trial",
                Description = "Battle against legendary dungeon bosses in a test of ultimate endurance.",
                Category = "Ultimate",
                RankRequired = "S",
                XPReward = 10000,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Quest
            {
                QuestId = 10,
                QuestName = "Lightning Step Challenge",
                Description = "A test of pure speed and reaction time, dodging phantom attacks.",
                Category = "Race",
                RankRequired = "D",
                XPReward = 600,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
        );
        }
    }
}
