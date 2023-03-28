using ScheduleMaster;

namespace ScheduleMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task("Пастроить дом",
                                Action.TakeVideo,
                                DateTime.Now,
                                new WorkScope(5, 80),
                                new Difficulty(6),
                                false,
                                false);
            Console.WriteLine($"{task1.WorkScope.Hours}:{task1.WorkScope.Minutes}");
            Console.ReadLine();
        }
    }
}
