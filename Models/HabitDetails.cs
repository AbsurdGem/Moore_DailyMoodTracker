namespace DailyLogApp.Models
{
    public class HabitDetails
    {
        public int SleepHours { get; set; }
        public int ExerciseMinutes { get; set; }
        public int WaterIntakeOz { get; set; }

        public HabitDetails(int sleep, int exercise, int water)
        {
            SleepHours = sleep;
            ExerciseMinutes = exercise;
            WaterIntakeOz = water;
        }

        public override string ToString()
        {
            return $"Sleep: {SleepHours} hrs | Exercise: {ExerciseMinutes} mins | Water: {WaterIntakeOz} oz";
        }
    }
}
