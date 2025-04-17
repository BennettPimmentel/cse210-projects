namespace EternalQuest.Models
{
    public class SimpleGoal : Goal
    {
        public bool IsComplete { get; set; }

        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            IsComplete = false;
        }

        public override void RecordEvent()
        {
            if (!IsComplete)
            {
                IsComplete = true;
                Console.WriteLine($"Goal {Name} completed! You've earned {Points} points.");
            }
            else
            {
                Console.WriteLine($"{Name} is already completed.");
            }
        }

        public override void DisplayGoal()
        {
            string status = IsComplete ? "[X]" : "[ ]";
            Console.WriteLine($"{status} {Name}: {Description} - Points: {Points}");
        }
    }
}
