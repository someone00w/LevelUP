namespace LevelUP.Domain
{
    public class UserAchievement : BaseDomainModel
    {
        public DateTime DateUnlocked { get; set; }
        public int UserId { get; set; }
        public int AchievementId { get; set; }
    }
}