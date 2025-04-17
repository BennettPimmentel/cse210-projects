namespace EternalQuest.Models
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points) { }

        public override void RecordEvent()
        {
            Console.WriteLine($"You've earned {Points} points for {Name}. Keep it up!");
        }

        public override void DisplayGoal()
        {
            Console.WriteLine($"{Name}: {Description} (Eternal Goal) - Points: {Points}");
        }
    }
}
