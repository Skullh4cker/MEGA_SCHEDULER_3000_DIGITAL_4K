using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaster
{
    internal class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Patronymic { get; private set; }
        public Gender Gender { get; private set; }
        public Temperament Temperament { get; private set; }
        public int WorkExperienceYears { get; private set; }
        public Task AssignedTask { get; private set; }
        public Employee(string name, string surname, string patronymic, Gender gender, Temperament temperament, int workExperienceYears, Task assignedTask)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Gender = gender;
            Temperament = temperament;
            WorkExperienceYears = workExperienceYears;
            AssignedTask = assignedTask;
        }
    }
}
