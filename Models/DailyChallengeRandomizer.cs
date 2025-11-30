using System;
using System.Collections.Generic;

namespace DailyLogApp.Models
{
    public class DailyChallengeRandomizer : IDailyChallenge
    {
        private static readonly List<string> _challenges = new()
        {
            "Drink one extra glass of water.",
            "Take a 10-minute walk.",
            "Write down 3 things you’re grateful for.",
            "Stretch for 5 minutes.",
            "Compliment yourself out loud — yes, out loud."
        };

        public string GetChallenge()
        {
            Random rnd = new Random();
            return _challenges[rnd.Next(_challenges.Count)];
        }
    }
}
