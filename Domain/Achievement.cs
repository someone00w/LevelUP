namespace LevelUP.Domain
{
    public class Achievement : BaseDomainModel
    {
        public int AchievementId { get; set; }
        public string? AchievementName { get; set; }
        public string? AchievementDescription { get; set; }
        public int? XPRequired { get; set; }
        public int? QuestsRequired { get; set; }
        public int? RankRequired { get; set; }
    }
}