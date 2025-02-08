namespace LevelUP.Domain
{
    public class Workout : BaseDomainModel
    {
        public int WorkoutId { get; set; }
        public string? WorkoutName { get; set; }
        public string? WorkoutDescription { get; set; }
    }
}