using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LevelUP.Data;
using LevelUP.Configurations.Entities;

namespace LevelUP.Data
{
    public class LevelUPContext(DbContextOptions<LevelUPContext> options) : IdentityDbContext<LevelUPUser>(options)
    {
        public DbSet<LevelUP.Domain.Achievement> Achievement { get; set; } = default!;
        public DbSet<LevelUP.Domain.Quest> Quest { get; set; } = default!;
        public DbSet<LevelUP.Domain.Reward> Reward { get; set; } = default!;
        public DbSet<LevelUP.Domain.UserAchievement> UserAchievement { get; set; } = default!;
        public DbSet<LevelUP.Domain.User> User { get; set; } = default!;
        public DbSet<LevelUP.Domain.UserQuest> UserQuest { get; set; } = default!;
        public DbSet<LevelUP.Domain.UserReward> UserReward { get; set; } = default!;
        public DbSet<LevelUP.Domain.Workout> Workout { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new QuestSeed());
            builder.ApplyConfiguration(new AchievementSeed());
            builder.ApplyConfiguration(new RewardSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());

        }
    }
}
