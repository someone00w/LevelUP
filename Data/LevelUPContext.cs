using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LevelUP.Data;
using LevelUP.Configurations.Entities;
using LevelUP.Domain;

namespace LevelUP.Data
{
    public class LevelUPContext(DbContextOptions<LevelUPContext> options) : IdentityDbContext<LevelUPUser>(options)
    {
        public DbSet<LevelUP.Domain.Achievement> Achievement { get; set; } = default!;
        public DbSet<LevelUP.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<LevelUP.Domain.Quest> Quest { get; set; } = default!;
        public DbSet<LevelUP.Domain.Staff> Staff { get; set; } = default!;
        public DbSet<LevelUP.Domain.UserAchievement> UserAchievement { get; set; } = default!;
        public DbSet<LevelUP.Domain.UserQuest> UserQuest { get; set; } = default!;
        public DbSet<LevelUP.Domain.Workout> Workout { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Quest>()
                .HasOne(q => q.Workout)
                .WithMany()
                .HasForeignKey(q => q.WorkoutId);

            builder.ApplyConfiguration(new WorkoutSeed());
            builder.ApplyConfiguration(new QuestSeed());
            builder.ApplyConfiguration(new AchievementSeed());
        }
    }
}
