class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Morgan's Sassy Mood Tracker - Week 4 Database Edition");

        DatabaseManager db = new DatabaseManager();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1 - Add Log");
            Console.WriteLine("2 - View Logs");
            Console.WriteLine("3 - Update Log Notes");
            Console.WriteLine("4 - Delete Log");
            Console.WriteLine("5 - Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    var newLog = CreateNewLog();
                    db.InsertLog(newLog);
                    Console.WriteLine("✨ Log added! You’re doing amazing sweetie.");
                    break;

                case "2":
                    var logs = db.GetAllLogs();
                    foreach (var log in logs)
                        Console.WriteLine(log.ToString());
                    break;

                case "3":
                    Console.Write("Enter log ID to update: ");
                    int idU = int.Parse(Console.ReadLine());
                    Console.Write("Enter new notes: ");
                    string notes = Console.ReadLine();
                    db.UpdateNotes(idU, notes);
                    break;

                case "4":
                    Console.Write("Enter log ID to delete: ");
                    int idD = int.Parse(Console.ReadLine());
                    db.DeleteLog(idD);
                    break;

                case "5":
                    running = false;
                    break;
            }
        }
    }
}
