namespace LevelUP.Domain
{
    public class UserQuest : BaseDomainModel
    {
        public int UserQuestId { get; set; }
        public string? QuestName { get; set; }
        public string Status { get; set; } = "Active";
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public int QuestId { get; set; }
        public Quest? Quest { get; set; }
    }
}