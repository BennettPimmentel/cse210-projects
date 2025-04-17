namespace EternalQuest.Models
{
    public class ChecklistGoal : Goal
    {
        public int TotalTimes { get; set; }
        public int TimesCompleted { get; set; }
        public int BonusPoints { get; set; }

        public ChecklistGoal(string name, string description, int points, int totalTimes, int bonusPoints)
            : base(name, description, points)
        {
            TotalTimes = totalTimes;
            TimesCompleted = 0;
            BonusPoints = bonusPoints;
        }

        public override void RecordEvent()
        {
            if (TimesCompleted < TotalTimes)
            {
                TimesCompleted++;
                Console.WriteLine($"Goal {Name} completed {TimesCompleted}/{TotalTimes} times. You've earned {Points} points.");

                if (TimesCompleted == TotalTimes)
                {
                    Console.WriteLine($"Bonus! You've completed the goal! You've earned {BonusPoints} additional points.");
                }
            }
            else
            {
                Console.WriteLine($"{Name} is already completed.");
            }
        }

        public override void DisplayGoal()
        {
            Console.WriteLine($"{Name}: {Description} - Completed {TimesCompleted}/{TotalTimes} times - Points: {Points}");
        }
    }
}
