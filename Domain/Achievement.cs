namespace LevelUP.Domain
{
    public class Achievement : BaseDomainModel
    {
        public string? AchievementName { get; set; }
        public string? Description { get; set; }
        public string? BadgeIcon { get; set; }
        public int XPRequired { get; set; }
    }
}