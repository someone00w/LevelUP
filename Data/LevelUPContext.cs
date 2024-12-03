using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LevelUP.Domain;
using FitnessApp.Configurations.Entities;

namespace LevelUP.Data
{
    public class LevelUPContext : DbContext
    {
        public LevelUPContext(DbContextOptions<LevelUPContext> options)
            : base(options)
        {
        }

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
        }
    }
}
