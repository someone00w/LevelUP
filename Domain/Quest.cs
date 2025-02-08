namespace LevelUP.Domain
{
    public class Quest : BaseDomainModel
    {
        public int QuestId { get; set; }
        public string? QuestName { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? RankRequired { get; set; }
        public int XPReward { get; set; }
        public string Status { get; set; } = "Incomplete";
    }
}