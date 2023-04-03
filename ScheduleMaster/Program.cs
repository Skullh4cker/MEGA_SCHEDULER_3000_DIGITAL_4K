using ScheduleMaster;

namespace ScheduleMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task("Найти цель",
                                Action.FindTarget,
                                new DateTime(2024, 12, 1),
                                new Time(1, 30),
                                new Difficulty(4),
                                false,
                                false);
            Task task2 = new Task("Заснять",
                                Action.TakePhoto,
                                new DateTime(2024, 12, 1),
                                new Time(0, 10),
                                new Difficulty(4),
                                false,
                                false);
            Task task3 = new Task("Позвонить",
                                Action.Call,
                                new DateTime(2024, 12, 1),
                                new Time(0, 10),
                                new Difficulty(6),
                                false,
                                false);
            DailyPlan plan = new DailyPlan("07:44", "18:59");
            Console.WriteLine($"Рабочий день с {plan.WorkingTime.StartTime.GetTime()} до {plan.WorkingTime.EndTime.GetTime()}");
            plan.AddTask(task1);
            plan.AddTask(task2);
            plan.AddTask(task3);
            plan.PrintTasksInPlan();
            Console.ReadLine();
        }
    }
}
