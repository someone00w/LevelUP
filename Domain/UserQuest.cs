namespace LevelUP.Domain
{
    public static class QuestStatusCodes
    {
        public const int Pending = 0;
        public const int InProgress = 1;
        public const int Completed = 2;
        public const int Failed = 3;

        // Converts the status code to a readable description
        public static string GetStatusDescription(int status)
        {
            return status switch
            {
                Pending => "Pending",
                InProgress => "In Progress",
                Completed => "Completed",
                Failed => "Failed",
                _ => "Unknown"
            };
        }
    }

    public class UserQuest : BaseDomainModel
    {
        public int Status { get; set; } // Stores the status as an integer
        public DateTime DateStarted { get; set; }
        public DateTime? DateCompleted { get; set; } // Nullable for incomplete quests
        public int UserId { get; set; } // Foreign Key to User
        public int QuestId { get; set; } // Foreign Key to Quest

        // Gets the human-readable status description
        public string GetStatusDescription()
        {
            return QuestStatusCodes.GetStatusDescription(Status);
        }
    }
}