namespace LevelUP.Domain
{
    public class Quest : BaseDomainModel
    {
        public string? QuestName { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? RankRequired { get; set; }
        public int XPReward { get; set; }
        public int WorkoutId { get; set; }
        public Workout? Workout { get; set; }
        public string? WorkoutNames { get; set; } = string.Empty;
        public List<Workout>? Workouts { get; set; }
    }
}