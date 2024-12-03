using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LevelUP.Domain;

namespace FitnessApp.Configurations.Entities
{
    public class AchievementSeed : IEntityTypeConfiguration<Achievement>
    {
        public void Configure(EntityTypeBuilder<Achievement> builder)
        {
            builder.HasData(
                new Achievement
                {
                    Id = 1,
                    AchievementName = "First Workout",
                    Description = "Complete your first workout.",
                    BadgeIcon = "first_workout.png",
                    XPRequired = 100
                },
                new Achievement
                {
                    Id = 2,
                    AchievementName = "Strength Master",
                    Description = "Complete 10 strength workouts.",
                    BadgeIcon = "strength_master.png",
                    XPRequired = 500
                }
            );
        }
    }
}