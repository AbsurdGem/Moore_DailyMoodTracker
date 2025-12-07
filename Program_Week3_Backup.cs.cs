using System;
using DailyLogApp.Models;

namespace DailyLogApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Morgan’s Mood Log - Week 3 Class Demo\n");

            // Polymorphism demo
            Mood mood = GetMoodFromUser();

            HabitDetails habits = new HabitDetails(
                sleep: 7,
                exercise: 20,
                water: 60
            );

            DailyLog log = new DailyLog(
                id: 1,
                date: DateTime.Now,
                mood: mood,
                habits: habits,
                notes: "Today was chaotic but fun."
            );

            Console.WriteLine(log.ToString());

            Console.WriteLine("\nRecommendation:");
            Console.WriteLine(log.ApplyRecommendation());

            Console.WriteLine("\nYour Random Challenge:");
            Console.WriteLine(log.AssignRandomChallenge());
        }

        static Mood GetMoodFromUser()
        {
            Console.WriteLine("How are you feeling today?");
            Console.WriteLine("1 = Happy");
            Console.WriteLine("2 = Grumpy");

            string input = Console.ReadLine();

            return input switch
            {
                "1" => new HappyMood(),
                "2" => new GrumpyMood(),
                _ => new HappyMood()
            };
        }
    }
}
