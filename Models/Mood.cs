using System;

namespace DailyLogApp.Models
{
    public abstract class Mood
    {
        public string MoodName { get; protected set; }

        public Mood(string name)
        {
            MoodName = name;
        }

        // Polymorphism here
        public abstract string GetSassyMessage();
    }
}
