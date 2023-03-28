using ScheduleMaster;

namespace ScheduleMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task("Пастроить дом",
                                Action.BuildHouse,
                                DateTime.Now,
                                new WorkScope(5, 80),
                                new Difficulty(6),
                                false,
                                false);
            Employee loh1 = new Employee("Александр",
                                        "Александров",
                                        "Александрович",
                                        Gender.Male,
                                        Temperament.Sanguine,
                                        3,
                                        task1);
            Console.WriteLine($"{loh1.Name} {loh1.Surname} {loh1.Patronymic}, назначена работа: {loh1.AssignedTask.Name}");
            Console.ReadLine();
        }
    }
}
