namespace LevelUP.Domain
{
    public class Reward : BaseDomainModel
    {
        public string? RewardName { get; set; }
        public string? Description { get; set; }
        public string? UnlockCriteria { get; set; }
    }
}