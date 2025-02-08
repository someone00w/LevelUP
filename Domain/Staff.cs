using LevelUP.Data;
namespace LevelUP.Domain
{
    public class Staff : BaseDomainModel
    {
        public int StaffId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        //Foreign key to LevelUPUser
        public string? UserId { get; set; }
        //navigation
        public LevelUPUser? User { get; set; }
    }
}