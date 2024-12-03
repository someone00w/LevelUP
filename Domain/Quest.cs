namespace LevelUP.Domain
{
    public class Quest : BaseDomainModel
    {
        public string? QuestName { get; set; }
        public string? Description { get; set; }
        public string? DifficultyLevel { get; set; }
        public int XPReward { get; set; }
        public string? Category { get; set; }
    }
}