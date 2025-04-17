using System;
using System.IO;
using EternalQuest.Models;

namespace EternalQuest.Services
{
    public class FileHandler
    {
        public static void SaveGoalsToFile(List<Goal> goals, string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var goal in goals)
                {
                    writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.Points}");
                }
            }
        }

        public static List<Goal> LoadGoalsFromFile(string filename)
        {
            List<Goal> goals = new List<Goal>();

            foreach (var line in File.ReadAllLines(filename))
            {
                var parts = line.Split(',');
                string goalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                Goal goal = goalType switch
                {
                    "SimpleGoal" => new SimpleGoal(name, description, points),
                    "EternalGoal" => new EternalGoal(name, description, points),
                    "ChecklistGoal" => new ChecklistGoal(name, description, points, 10, 500), // Example for ChecklistGoal
                    _ => null
                };

                if (goal != null) goals.Add(goal);
            }

            return goals;
        }
    }
}
