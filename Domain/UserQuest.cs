namespace LevelUP.Domain
{
    public class UserQuest : BaseDomainModel
    {
        public int UserQuestId { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public int QuestId { get; set; }
        public Quest? Quest { get; set; }
    }
}