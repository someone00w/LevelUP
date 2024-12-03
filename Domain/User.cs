namespace LevelUP.Domain
{
    public class User : BaseDomainModel
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public int Level { get; set; }
        public int XP { get; set; }
        public DateTime DateCreated { get; set; }
    }
}