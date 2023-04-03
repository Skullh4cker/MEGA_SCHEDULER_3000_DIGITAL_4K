using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaster
{
    internal class Task
    {
        public string Name { get; private set; }
        public Action Action { get; private set; }
        public DateTime Deadline { get; private set; }
        //TODO: Поменять название WorkScope?
        public Time WorkScope { get; private set; }
        public Difficulty Difficulty { get; private set; }
        public Status Status { get; private set; }
        public bool IsDelegable { get; private set; }
        public bool IsSeparable { get; private set; }
        public HashSet<Task> Subtasks { get; private set; }
        public Task(string name, Action action, DateTime deadline, Time workscope, Difficulty difficulty, bool delegable, bool separable)
        {
            Name = name;
            Action = action;
            Deadline = deadline;
            WorkScope = workscope;
            Difficulty = difficulty;
            Status = Status.Awaiting;
            IsDelegable = delegable;
            IsSeparable = separable;
            Subtasks = new HashSet<Task>();
        }
        public double GetPriority()
        {
            return (this.Difficulty.Level * Time.TotalMinutes(WorkScope)) / ((Deadline - DateTime.Now).TotalHours);
        }
        public void SetStatus(Status status)
        {
            Status = status;
        }
    }
}
