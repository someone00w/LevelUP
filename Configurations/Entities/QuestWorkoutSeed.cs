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
                new QuestWorkout { QuestWorkoutId = 1, QuestId = 1, WorkoutId = 1, Status = "Incomplete" },
                new QuestWorkout { QuestWorkoutId = 2, QuestId = 1, WorkoutId = 2, Status = "Incomplete" },
                new QuestWorkout { QuestWorkoutId = 3, QuestId = 1, WorkoutId = 6, Status = "Incomplete" },

                new QuestWorkout { QuestWorkoutId = 4, QuestId = 2, WorkoutId = 8, Status = "Incomplete" },
                new QuestWorkout { QuestWorkoutId = 5, QuestId = 2, WorkoutId = 7, Status = "Incomplete" },

                new QuestWorkout { QuestWorkoutId = 6, QuestId = 3, WorkoutId = 3, Status = "Incomplete" },
                new QuestWorkout { QuestWorkoutId = 7, QuestId = 3, WorkoutId = 9, Status = "Incomplete" },

                new QuestWorkout { QuestWorkoutId = 8, QuestId = 4, WorkoutId = 6, Status = "Incomplete" },
                new QuestWorkout { QuestWorkoutId = 9, QuestId = 4, WorkoutId = 10, Status = "Incomplete" },

                new QuestWorkout { QuestWorkoutId = 10, QuestId = 5, WorkoutId = 1, Status = "Incomplete" },
                new QuestWorkout { QuestWorkoutId = 11, QuestId = 5, WorkoutId = 2, Status = "Incomplete" },
                new QuestWorkout { QuestWorkoutId = 12, QuestId = 5, WorkoutId = 9, Status = "Incomplete" }
            );
        }
    }
}
