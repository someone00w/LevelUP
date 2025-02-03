using LevelUP.Data;

namespace LevelUP.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public int XPAmount { get; set; }
        public string? Rank { get; set; }

        //Foreign key to LevelUPUser
        public string? UserId { get; set; }
        //navigation
        public LevelUPUser? User { get; set; }
    }
}