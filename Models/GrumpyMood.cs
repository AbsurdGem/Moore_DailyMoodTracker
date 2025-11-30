namespace DailyLogApp.Models
{
    public class GrumpyMood : Mood
    {
        public GrumpyMood() : base("Grumpy") { }

        public override string GetSassyMessage()
        {
            return "Oof. Someone needs a nap, a snack, or possibly both. 😤";
        }
    }
}
