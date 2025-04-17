using System;
using EternalQuest.Models;
using EternalQuest.Services;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager goalManager = new GoalManager();

            // Crear algunas metas
            Goal marathon = new SimpleGoal("Run Marathon", "Complete a marathon and earn 1000 points", 1000);
            Goal scriptureStudy = new EternalGoal("Scripture Study", "Read the scriptures every day", 100);
            Goal templeAttendance = new ChecklistGoal("Attend the Temple", "Attend the temple 10 times", 50, 10, 500);

            // Añadir metas
            goalManager.AddGoal(marathon);
            goalManager.AddGoal(scriptureStudy);
            goalManager.AddGoal(templeAttendance);

            // Mostrar metas
            Console.WriteLine("Your Goals:");
            goalManager.DisplayGoals();

            // Registrar eventos
            Console.WriteLine("\nRecording Events:");
            goalManager.RecordGoalEvent(0); // Marathon goal
            goalManager.RecordGoalEvent(1); // Scripture study goal
            goalManager.RecordGoalEvent(2); // Temple attendance goal

            // Guardar metas en un archivo
            FileHandler.SaveGoalsToFile(new List<Goal> { marathon, scriptureStudy, templeAttendance }, "goals.txt");

            // Cargar metas desde un archivo
            var loadedGoals = FileHandler.LoadGoalsFromFile("goals.txt");

            Console.WriteLine("\nLoaded Goals from File:");
            foreach (var goal in loadedGoals)
            {
                goal.DisplayGoal();
            }
        }
    }
}