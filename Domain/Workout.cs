namespace LevelUP.Domain
{
    public class Workout : BaseDomainModel
    {
        public string? WorkoutName { get; set; }
        public string? WorkoutDescription { get; set; }
        public string? Category { get; set; }
    }
}