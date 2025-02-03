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
                    Id = 1,
                    QuestName = "E-Rank Warm-up",
                    Description = "Basic training for new hunters to improve endurance and strength.",
                    Category = "Training",
                    RankRequired = "E",
                    XPReward = 100,
                    WorkoutId = 1 // Push-Ups
                },
                new Quest
                {
                    Id = 2,
                    QuestName = "Survival Instincts",
                    Description = "Increase agility and stamina to survive in low-level dungeons.",
                    Category = "Endurance",
                    RankRequired = "E",
                    XPReward = 200,
                    WorkoutId = 6 // Jump Rope
                },
                new Quest
                {
                    Id = 3,
                    QuestName = "D-Rank Power Boost",
                    Description = "Enhance strength with rigorous training.",
                    Category = "Strength",
                    RankRequired = "D",
                    XPReward = 500,
                    WorkoutId = 2 // Squats
                },
                new Quest
                {
                    Id = 4,
                    QuestName = "Dungeon Sprint",
                    Description = "Improve speed and reaction time for quick escapes.",
                    Category = "Agility",
                    RankRequired = "D",
                    XPReward = 700,
                    WorkoutId = 8 // Mountain Climbers
                },
                new Quest
                {
                    Id = 5,
                    QuestName = "C-Rank Warrior's Test",
                    Description = "A challenging workout to prepare for higher-ranked missions.",
                    Category = "Full Body",
                    RankRequired = "C",
                    XPReward = 1200,
                    WorkoutId = 7 // Burpees
                },
                new Quest
                {
                    Id = 6,
                    QuestName = "B-Rank Hunter's Discipline",
                    Description = "Master balance and endurance for prolonged battles.",
                    Category = "Core",
                    RankRequired = "B",
                    XPReward = 2000,
                    WorkoutId = 4 // Plank
                },
                new Quest
                {
                    Id = 7,
                    QuestName = "A-Rank Titan's Strength",
                    Description = "Advanced training to develop elite hunter power.",
                    Category = "Strength",
                    RankRequired = "A",
                    XPReward = 4000,
                    WorkoutId = 9 // Deadlifts
                },
                new Quest
                {
                    Id = 8,
                    QuestName = "Shadow Monarch's Challenge",
                    Description = "Surpass your limits with extreme training.",
                    Category = "Endurance",
                    RankRequired = "S",
                    XPReward = 7000,
                    WorkoutId = 5 // Lunges
                },
                new Quest
                {
                    Id = 9,
                    QuestName = "S-Rank Battle Mastery",
                    Description = "A test of skill, power, and endurance for elite hunters.",
                    Category = "Full Body",
                    RankRequired = "S",
                    XPReward = 10000,
                    WorkoutId = 3 // Pull-Ups
                },
                new Quest
                {
                    Id = 10,
                    QuestName = "God of War's Training",
                    Description = "Only the strongest can complete this ultimate test.",
                    Category = "Ultimate",
                    RankRequired = "SS",
                    XPReward = 20000,
                    WorkoutId = 10 // Bicycle Crunches
                }
            );
        }
    }
}