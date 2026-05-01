namespace Task_planner.API.Models
{
    public class Task
    {
        public long Id { get; set; }
        public string Title { get; set; }
        // public string[] Tags { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        // public DateTime NotificationTime { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
