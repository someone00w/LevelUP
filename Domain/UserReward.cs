namespace LevelUP.Domain
{
    public class UserReward : BaseDomainModel
    {
        public DateTime DateClaimed { get; set; }
        public int UserId { get; set; }
        public int RewardId { get; set; }
    }
}