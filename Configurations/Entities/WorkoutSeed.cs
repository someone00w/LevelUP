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
                    WorkoutId = 1,
                    WorkoutName = "Push-Ups",
                    WorkoutDescription = "A basic upper body exercise that strengthens the chest, shoulders, and triceps.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Workout
                {
                    WorkoutId = 2,
                    WorkoutName = "Squats",
                    WorkoutDescription = "A lower body exercise that targets the quadriceps, hamstrings, and glutes.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Workout
                {
                    WorkoutId = 3,
                    WorkoutName = "Pull-Ups",
                    WorkoutDescription = "An upper body exercise that builds back and bicep strength.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Workout
                {
                    WorkoutId = 4,
                    WorkoutName = "Plank",
                    WorkoutDescription = "A core exercise that strengthens the abdominal muscles and improves endurance.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Workout
                {
                    WorkoutId = 5,
                    WorkoutName = "Lunges",
                    WorkoutDescription = "A lower body exercise that improves balance and strengthens the legs.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Workout
                {
                    WorkoutId = 6,
                    WorkoutName = "Jump Rope",
                    WorkoutDescription = "A cardiovascular exercise that enhances coordination and endurance.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Workout
                {
                    WorkoutId = 7,
                    WorkoutName = "Burpees",
                    WorkoutDescription = "A full-body exercise that combines strength and cardio training.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Workout
                {
                    WorkoutId = 8,
                    WorkoutName = "Mountain Climbers",
                    WorkoutDescription = "A cardio and core workout that improves agility and endurance.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Workout
                {
                    WorkoutId = 9,
                    WorkoutName = "Deadlifts",
                    WorkoutDescription = "A strength exercise that targets the lower back, glutes, and hamstrings.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Workout
                {
                    WorkoutId = 10,
                    WorkoutName = "Bicycle Crunches",
                    WorkoutDescription = "A core workout that strengthens the abdominal muscles and obliques.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}