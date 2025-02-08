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
                new QuestWorkout { QuestWorkoutId = 1, QuestId = 1, WorkoutId = 1, IsCompleted = false },
                new QuestWorkout { QuestWorkoutId = 2, QuestId = 1, WorkoutId = 2, IsCompleted = false },
                new QuestWorkout { QuestWorkoutId = 3, QuestId = 1, WorkoutId = 6, IsCompleted = false },

                new QuestWorkout { QuestWorkoutId = 4, QuestId = 2, WorkoutId = 8, IsCompleted = false },
                new QuestWorkout { QuestWorkoutId = 5, QuestId = 2, WorkoutId = 7, IsCompleted = false },

                new QuestWorkout { QuestWorkoutId = 6, QuestId = 3, WorkoutId = 3, IsCompleted = false },
                new QuestWorkout { QuestWorkoutId = 7, QuestId = 3, WorkoutId = 9, IsCompleted = false },

                new QuestWorkout { QuestWorkoutId = 8, QuestId = 4, WorkoutId = 6, IsCompleted = false },
                new QuestWorkout { QuestWorkoutId = 9, QuestId = 4, WorkoutId = 10, IsCompleted = false },

                new QuestWorkout { QuestWorkoutId = 10, QuestId = 5, WorkoutId = 1, IsCompleted = false },
                new QuestWorkout { QuestWorkoutId = 11, QuestId = 5, WorkoutId = 2, IsCompleted = false },
                new QuestWorkout { QuestWorkoutId = 12, QuestId = 5, WorkoutId = 9, IsCompleted = false }
            );
        }
    }
}
