using System;

namespace DailyLogApp.Models
{
    public class DailyLog
    {
        public int EntryID { get; set; }
        public DateTime EntryDate { get; set; }
        public Mood UserMood { get; set; }        // Abstract → polymorphism
        public HabitDetails Habits { get; set; }  // Composition
        public string Notes { get; set; }

        public DailyLog(int id, DateTime date, Mood mood, HabitDetails habits, string notes)
        {
            EntryID = id;
            EntryDate = date;
            UserMood = mood;
            Habits = habits;
            Notes = notes;
        }

        public string ApplyRecommendation()
        {
            IRecommendation rec = new SassyRecommendation(UserMood);
            return rec.GenerateMessage();
        }

        public string AssignRandomChallenge()
        {
            IDailyChallenge challenge = new DailyChallengeRandomizer();
            return challenge.GetChallenge();
        }

        public override string ToString()
        {
            return $"\n=== Daily Log Entry #{EntryID} ===\n" +
                   $"Date: {EntryDate.ToShortDateString()}\n" +
                   $"Mood: {UserMood.MoodName}\n" +
                   $"Habits: {Habits}\n" +
                   $"Notes: {Notes}\n";
        }
    }
}
