using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LevelUP.Domain;

namespace LevelUP.Configurations.Entities
{
    public class RewardSeed : IEntityTypeConfiguration<Reward>
    {
        public void Configure(EntityTypeBuilder<Reward> builder)
        {
            builder.HasData(
                new Reward
                {
                    Id = 1,
                    RewardName = "Gold Medal",
                    Description = "Awarded for completing 5 quests.",
                    UnlockCriteria = "Complete 5 quests."
                },
                new Reward
                {
                    Id = 2,
                    RewardName = "Fitness Guru",
                    Description = "Awarded for completing 10 workouts.",
                    UnlockCriteria = "Complete 10 workouts."
                }
            );
        }
    }
}