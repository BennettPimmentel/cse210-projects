using EternalQuest.Models;
using System.Collections.Generic;

namespace EternalQuest.Services
{
    public class GoalManager
    {
        private List<Goal> goals = new List<Goal>();

        public void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }

        public void DisplayGoals()
        {
            foreach (Goal goal in goals)
            {
                goal.DisplayGoal();
            }
        }

        public void RecordGoalEvent(int goalIndex)
        {
            if (goalIndex >= 0 && goalIndex < goals.Count)
            {
                goals[goalIndex].RecordEvent();
            }
            else
            {
                Console.WriteLine("Invalid goal index.");
            }
        }
    }
}
