using Microsoft.EntityFrameworkCore;
using LevelUP.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LevelUP.Configurations.Entities
{
    public class QuestWorkoutSeed : IEntityTypeConfiguration<QuestWorkout>
    {
        public void Configure(EntityTypeBuilder<QuestWorkout> builder)
        {
            builder.HasData(
                new QuestWorkout
                {
                    QuestWorkoutId = 1,
                    QuestId = 1,
                    WorkoutId = 1,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 2,
                    QuestId = 1,
                    WorkoutId = 2,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 3,
                    QuestId = 1,
                    WorkoutId = 6,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 4,
                    QuestId = 2,
                    WorkoutId = 8,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 5,
                    QuestId = 2,
                    WorkoutId = 7,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 6,
                    QuestId = 3,
                    WorkoutId = 3,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 7,
                    QuestId = 3,
                    WorkoutId = 9,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 8,
                    QuestId = 4,
                    WorkoutId = 6,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 9,
                    QuestId = 4,
                    WorkoutId = 10,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 10,
                    QuestId = 5,
                    WorkoutId = 1,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 11,
                    QuestId = 5,
                    WorkoutId = 2,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 12,
                    QuestId = 5,
                    WorkoutId = 9,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 13,
                    QuestId = 6,
                    WorkoutId = 4,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 14,
                    QuestId = 6,
                    WorkoutId = 5,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 15,
                    QuestId = 6,
                    WorkoutId = 7,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 16,
                    QuestId = 7,
                    WorkoutId = 8,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 17,
                    QuestId = 7,
                    WorkoutId = 10,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 18,
                    QuestId = 8,
                    WorkoutId = 1,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 19,
                    QuestId = 8,
                    WorkoutId = 3,
                    Status = "Incomplete",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new QuestWorkout
                {
                    QuestWorkoutId = 20,
                    QuestId = 8,
                    WorkoutId = 6,
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
