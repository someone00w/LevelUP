namespace LevelUP.Domain
{
    public class Workout : BaseDomainModel
    {
        public string? WorkoutName { get; set; }
        public int Duration { get; set; } //Duration in minutes
        public int CaloriesBurned { get; set; }
        public int QuestId { get; set; }
    }
}