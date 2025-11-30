"# Moore_DailyMoodTracker" 
# Daily Mood & Habit Tracker  
### SDC320 Course Project – Phase 1 (Class Implementation)  
**Developer:** Morgan Moore  

---

## 📌 Project Overview
Daily Mood & Habit Tracker is a C# terminal-based application designed to log the user’s mood, daily habits, and personalized sassy recommendations.  
This project demonstrates object-oriented programming concepts including:

- Interfaces  
- Abstract classes  
- Polymorphism  
- Composition  
- Constructors & access specifiers  
- Data modeling for future SQLite CRUD operations (Week 4)

---

## 🧱 Phase 1 Deliverables (Week 3)
This submission includes **full class implementation** based on the design document:

### ✔ Implemented Classes
- `DailyLog`  
- `HabitDetails` (Composition class)  
- `Mood` (Abstract base class)  
- `SassyMood` (Derived class)  
- `IRecommendation` (Interface)  
- `SassyRecommendation` (Implementation class)  
- `IDailyChallenge` (Interface)  
- `RandomChallenge` (Implements IDailyChallenge)  

### ✔ OOP Concepts Demonstrated
- **Abstract class:** `Mood`
- **Polymorphism:** Mood → SassyMood; Recommendation engine
- **Interface usage:** `IRecommendation`, `IDailyChallenge`
- **Composition:** DailyLog → HabitDetails
- **Constructor overloading**
- **Access specifiers:** Proper use of `private`, `public`, `protected`
- **Formatted output:** All classes override `ToString()`

Database interactions will be added in **Week 4**.

---

## 🗂 Project Structure
/DailyMoodTracker
├── Program.cs
├── DailyLog.cs
├── Mood.cs
├── SassyMood.cs
├── HabitDetails.cs
├── IRecommendation.cs
├── SassyRecommendation.cs
├── IDailyChallenge.cs
├── RandomChallenge.cs
├── README.md
└── (SQLite integration coming in Week 4)


---

## 🚀 How to Run
From a terminal inside the project directory:

```bash
dotnet build
dotnet run
