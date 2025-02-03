namespace LevelUP.Domain
{
    public class UserQuest : BaseDomainModel
    {
        public int CustId { get; set; }
        public Customer? Cust { get; set; }
        public int QuestId { get; set; }
        public Quest? Quest { get; set; }
    }
}