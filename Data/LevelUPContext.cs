using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LevelUP.Data;
using LevelUP.Configurations.Entities;
using LevelUP.Domain;
using CarRentalManagement.Configurations.Entities;

namespace LevelUP.Data
{
    public class LevelUPContext(DbContextOptions<LevelUPContext> options) : IdentityDbContext<LevelUPUser>(options)
    {
        public DbSet<LevelUP.Domain.Achievement> Achievement { get; set; } = default!;
        public DbSet<LevelUP.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<LevelUP.Domain.Quest> Quest { get; set; } = default!;
        public DbSet<LevelUP.Domain.QuestWorkout> QuestWorkout { get; set; } = default!;
        public DbSet<LevelUP.Domain.Staff> Staff { get; set; } = default!;
        public DbSet<LevelUP.Domain.UserAchievement> UserAchievement { get; set; } = default!;
        public DbSet<LevelUP.Domain.UserQuest> UserQuest { get; set; } = default!;
        public DbSet<LevelUP.Domain.Workout> Workout { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserAchievement>()
        .HasOne(ua => ua.Customer)
        .WithMany()
        .HasForeignKey(ua => ua.CustomerId)
        .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<UserAchievement>()
                .HasOne(ua => ua.Achievement)
                .WithMany()
                .HasForeignKey(ua => ua.AchievementId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<UserQuest>()
                .HasOne(uq => uq.Customer)
                .WithMany()
                .HasForeignKey(uq => uq.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<UserQuest>()
                .HasOne(uq => uq.Quest)
                .WithMany()
                .HasForeignKey(uq => uq.QuestId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<QuestWorkout>()
                .HasOne(qw => qw.Quest)
                .WithMany()
                .HasForeignKey(qw => qw.QuestId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<QuestWorkout>()
                .HasOne(qw => qw.Workout)
                .WithMany()
                .HasForeignKey(qw => qw.WorkoutId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ApplyConfiguration(new WorkoutSeed());
            builder.ApplyConfiguration(new QuestSeed());
            builder.ApplyConfiguration(new AchievementSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new StaffSeed());
        }
    }
}
