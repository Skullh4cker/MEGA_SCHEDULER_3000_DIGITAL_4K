using ScheduleMaster; // Техзадание дерьмо
                        // Заказчики мудаки
namespace ScheduleMaster// Разрабы нихуя не понимают
{                       // Менеджеры хотят зарплату
    class Program      // Скобелев хочет в Чикаго
    {
        static void Main(string[] args)
        {
            Task task1 = new Task("Пастроить дом сука быстро бля",
                                Action.BuildHouse,
                                DateTime.Now,
                                new WorkScope(5, 80),
                                new Difficulty(6),
                                false,
                                false);
            Employee huila = new Employee("Александр",
                                        "Александров",
                                        "Александрович",
                                        Gender.Male,
                                        Temperament.Sanguine,
                                        3,
                                        task1);
            Console.WriteLine($"{huila.Name} {huila.Surname} {huila.Patronymic}, назначена работа: {huila.AssignedTask.Name}");
            Console.ReadLine();
        }
    }
}
