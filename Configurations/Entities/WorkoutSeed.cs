using Microsoft.EntityFrameworkCore;
using LevelUP.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LevelUP.Configurations.Entities
{
    public class WorkoutSeed : IEntityTypeConfiguration<Workout>
    {
        public void Configure(EntityTypeBuilder<Workout> builder)
        {
            builder.HasData(
                new Workout
                {
                    Id = 1,
                    WorkoutName = "Push-Ups",
                    WorkoutDescription = "A basic upper body exercise that strengthens the chest, shoulders, and triceps.",
                    Category = "Strength"
                },
                new Workout
                {
                    Id = 2,
                    WorkoutName = "Squats",
                    WorkoutDescription = "A lower body exercise that targets the quadriceps, hamstrings, and glutes.",
                    Category = "Strength"
                },
                new Workout
                {
                    Id = 3,
                    WorkoutName = "Pull-Ups",
                    WorkoutDescription = "An upper body exercise that builds back and bicep strength.",
                    Category = "Strength"
                },
                new Workout
                {
                    Id = 4,
                    WorkoutName = "Plank",
                    WorkoutDescription = "A core exercise that strengthens the abdominal muscles and improves endurance.",
                    Category = "Core"
                },
                new Workout
                {
                    Id = 5,
                    WorkoutName = "Lunges",
                    WorkoutDescription = "A lower body exercise that improves balance and strengthens the legs.",
                    Category = "Strength"
                },
                new Workout
                {
                    Id = 6,
                    WorkoutName = "Jump Rope",
                    WorkoutDescription = "A cardiovascular exercise that enhances coordination and endurance.",
                    Category = "Cardio"
                },
                new Workout
                {
                    Id = 7,
                    WorkoutName = "Burpees",
                    WorkoutDescription = "A full-body exercise that combines strength and cardio training.",
                    Category = "Full Body"
                },
                new Workout
                {
                    Id = 8,
                    WorkoutName = "Mountain Climbers",
                    WorkoutDescription = "A cardio and core workout that improves agility and endurance.",
                    Category = "Cardio"
                },
                new Workout
                {
                    Id = 9,
                    WorkoutName = "Deadlifts",
                    WorkoutDescription = "A strength exercise that targets the lower back, glutes, and hamstrings.",
                    Category = "Strength"
                },
                new Workout
                {
                    Id = 10,
                    WorkoutName = "Bicycle Crunches",
                    WorkoutDescription = "A core workout that strengthens the abdominal muscles and obliques.",
                    Category = "Core"
                }
            );
        }
    }
}