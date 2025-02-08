namespace LevelUP.Domain
{
    public class UserAchievement : BaseDomainModel
    {
        public int UserAchievementId { get; set; }
        public DateTime DateUnlocked { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public int AchievementId { get; set; }
        public Achievement? Achievement { get; set; }
    }
} 