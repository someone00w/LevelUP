namespace LevelUP.Domain
{
    public class QuestWorkout : BaseDomainModel
    {
        public int QuestWorkoutId { get; set; }
        public int QuestId { get; set; }
        public int WorkoutId { get; set; }
        public string Status { get; set; } = "Incomplete";

        // ✅ Navigation properties
        public Quest Quest { get; set; } = null!;
        public Workout Workout { get; set; } = null!;
    }

}