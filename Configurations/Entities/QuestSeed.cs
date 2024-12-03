using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LevelUP.Domain;

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
                    QuestName = "Beginner's Challenge",
                    Description = "Complete your first workout!",
                    DifficultyLevel = "Easy",
                    XPReward = 100,
                    Category = "Cardio"
                },
                new Quest
                {
                    Id = 2,
                    QuestName = "Strength Training",
                    Description = "Complete 5 strength workouts.",
                    DifficultyLevel = "Medium",
                    XPReward = 200,
                    Category = "Strength"
                }
            );
        }
    }
}