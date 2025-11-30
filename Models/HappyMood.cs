namespace DailyLogApp.Models
{
    public class HappyMood : Mood
    {
        public HappyMood() : base("Happy") { }

        public override string GetSassyMessage()
        {
            return "You're glowing today — keep up that main-character energy ✨";
        }
    }
}
