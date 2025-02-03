namespace LevelUP.Domain
{
    public class UserAchievement : BaseDomainModel
    {
        public DateTime DateUnlocked { get; set; }
        public int CustId { get; set; }
        public Customer? Cust { get; set; }
        public int AchievementId { get; set; }
        public Achievement? Achievement { get; set; }
    }
}