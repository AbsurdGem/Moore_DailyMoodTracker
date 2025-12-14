# Daily Mood & Habit Tracker
**Repository Name:** DailyMoodHabitTracker

A personality-driven, slightly sarcastic C# console application that allows users to log daily moods, habits, and notes while receiving personalized recommendations and randomized challenges.

This project was developed as a final course project to demonstrate Object-Oriented Programming (OOP) concepts and SQLite database integration in C#.

---

## ✨ Features
- Terminal-based user input and output
- Daily mood and habit tracking
- Personalized, sassy recommendations
- Random daily challenges
- SQLite database with full CRUD operations
- Clean object-oriented architecture

---

## 🧠 OOP Concepts Demonstrated
- **Inheritance** (Mood hierarchy)
- **Abstract Classes** (Mood base class)
- **Interfaces** (Recommendation and Challenge behaviors)
- **Polymorphism** (Dynamic mood and recommendation handling)
- **Composition** (DailyLog contains HabitDetails)
- **Constructors & Access Specifiers**

---

## 🗄 Database Design
**SQLite Database: `database.db`**

**Table: DailyLogs**
| Field | Type | Description |
|------|------|------------|
| EntryID | INTEGER PK AUTOINCREMENT | Unique entry ID |
| EntryDate | TEXT | Date of log |
| Mood | TEXT | User mood |
| SleepHours | INTEGER | Hours slept |
| ExerciseMinutes | INTEGER | Exercise duration |
| WaterIntakeOz | INTEGER | Water intake |
| Notes | TEXT | Optional notes |

CRUD operations are handled through the `DatabaseManager` class.

---

## 🚀 How to Run
1. Open the project in Visual Studio Code
2. Ensure `System.Data.SQLite` is installed
3. Build the project
4. Run from the terminal
5. Database initializes automatically

---

## 🏷 GitHub Release Tags
- **Phase #1** — Class Implementation
- **Phase #2** — Database Integration
- **Phase #3** — Final Submission

---

## 📌 Project Summary

This project demonstrates my ability to design and implement a complete C# console application using object-oriented principles and persistent data storage. The application was built incrementally, beginning with proposal and design, followed by class implementation and database integration.

Throughout development, I focused on clean architecture, readability, and meeting all core project requirements. A personalized and humorous tone was intentionally added to make the application engaging while still maintaining professional code standards.

This project reflects my growing confidence in C#, OOP design, and working with SQLite databases, and it represents a strong foundation for future software development projects.

---

## 👑 Author
**Morgan Moore**
> Note: A video demonstration was not included for this submission.
