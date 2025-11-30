using System;

namespace DailyLogApp.Models
{
    public class SassyRecommendation : IRecommendation
    {
        private Mood MoodInput;

        public SassyRecommendation(Mood mood)
        {
            MoodInput = mood;
        }

        public string GenerateMessage()
        {
            return $"Based on your mood ({MoodInput.MoodName}), here's my hot take: {MoodInput.GetSassyMessage()}";
        }
    }
}
