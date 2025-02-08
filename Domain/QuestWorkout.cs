namespace LevelUP.Domain
{
    public class QuestWorkout : BaseDomainModel
    {
        public int QuestWorkoutId { get; set; }
        public string Status { get; set; } = "Incomplete";

        public int QuestId { get; set; }
        public Quest Quest { get; set; } = default!;

        public int WorkoutId { get; set; }
        public Workout Workout { get; set; } = default!;
    }
}