using System;
using System.Collections.Generic;
using System.Data.SQLite;

public class DatabaseManager
{
    private string _connectionString = "Data Source=moodtracker.db;Version=3;";

    public DatabaseManager()
    {
        InitializeDatabase();
    }

    private void InitializeDatabase()
    {
        using (var conn = new SQLiteConnection(_connectionString))
        {
            conn.Open();

            string sql = @"
                CREATE TABLE IF NOT EXISTS DailyLogs (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    EntryDate TEXT NOT NULL,
                    Mood TEXT NOT NULL,
                    SleepHours INTEGER,
                    ExerciseMinutes INTEGER,
                    WaterIntake INTEGER,
                    Notes TEXT
                );
            ";

            using (var cmd = new SQLiteCommand(sql, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }

    // CREATE
    public void InsertLog(DailyLog log)
    {
        using (var conn = new SQLiteConnection(_connectionString))
        {
            conn.Open();

            string sql = @"
                INSERT INTO DailyLogs (EntryDate, Mood, SleepHours, ExerciseMinutes, WaterIntake, Notes)
                VALUES (@EntryDate, @Mood, @Sleep, @Exercise, @Water, @Notes);
            ";

            using (var cmd = new SQLiteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@EntryDate", log.EntryDate.ToString());
                cmd.Parameters.AddWithValue("@Mood", log.UserMood.MoodName);
                cmd.Parameters.AddWithValue("@Sleep", log.Habits.SleepHours);
                cmd.Parameters.AddWithValue("@Exercise", log.Habits.ExerciseMinutes);
                cmd.Parameters.AddWithValue("@Water", log.Habits.WaterIntakeOz);
                cmd.Parameters.AddWithValue("@Notes", log.Notes);

                cmd.ExecuteNonQuery();
            }
        }
    }

    // READ ALL
    public List<DailyLog> GetAllLogs()
    {
        var logs = new List<DailyLog>();

        using (var conn = new SQLiteConnection(_connectionString))
        {
            conn.Open();
            string sql = "SELECT * FROM DailyLogs";

            using (var cmd = new SQLiteCommand(sql, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var log = new DailyLog
                    {
                        EntryID = reader.GetInt32(0),
                        EntryDate = DateTime.Parse(reader.GetString(1)),
                        UserMood = new NeutralMood(), // Replace later with factory method
                        Notes = reader.GetString(6),
                        Habits = new HabitDetails
                        {
                            SleepHours = reader.GetInt32(3),
                            ExerciseMinutes = reader.GetInt32(4),
                            WaterIntakeOz = reader.GetInt32(5)
                        }
                    };

                    logs.Add(log);
                }
            }
        }

        return logs;
    }

    // UPDATE
    public void UpdateNotes(int id, string newNotes)
    {
        using (var conn = new SQLiteConnection(_connectionString))
        {
            conn.Open();
            string sql = "UPDATE DailyLogs SET Notes = @Notes WHERE Id = @Id";

            using (var cmd = new SQLiteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Notes", newNotes);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // DELETE
    public void DeleteLog(int id)
    {
        using (var conn = new SQLiteConnection(_connectionString))
        {
            conn.Open();
            string sql = "DELETE FROM DailyLogs WHERE Id = @Id";

            using (var cmd = new SQLiteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
