namespace LevelUP.Domain
{
    public class Quest : BaseDomainModel
    {
        public int QuestId { get; set; }
        public string QuestName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public int XPReward { get; set; }
        public string RankRequired { get; set; } = "D";
        public string Status { get; set; } = "Active";

        // ✅ Navigation property for related workouts
        public List<QuestWorkout> QuestWorkouts { get; set; } = new();
    }

}