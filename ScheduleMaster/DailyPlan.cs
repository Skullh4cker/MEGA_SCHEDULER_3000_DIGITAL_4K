using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaster
{
    internal class DailyPlan
    {
        public TimeInterval WorkingTime { get; private set; }
        public List<TimeInterval> DailySchedule { get; private set; }
        public List<Task> DailyTasks { get; private set; }
        public DailyPlan(string start, string end) 
        {
            WorkingTime = new TimeInterval(start, end);
            DailySchedule = new List<TimeInterval>();
            DailyTasks = new List<Task>();
        }
        public void AddTask(Task task)
        {
            DailyTasks.Add(task);
            TaskEmbed(task);
        }
        public void RemoveTask(Task task) 
        {
            DailyTasks.Remove(task);
        }
        private void TaskEmbed(Task task)
        {
            DailySchedule.Add(Scheduler.EmbedTask(task, GetFreeTimeIntervals()));
        }
        public void PrintTasksInPlan()
        {
            for(int i = 0; i< DailyTasks.Count; i++)
            {
                Console.WriteLine($"Задача: {DailyTasks[i].Name}; Время начала: {DailySchedule[i].StartTime.GetTime()}; Время окончания: {DailySchedule[i].EndTime.GetTime()};");
            }
        }
        private List<TimeInterval> GetFreeTimeIntervals()
        {
            List<TimeInterval> FreeTime = new List<TimeInterval>();
            if (DailySchedule.Count != 0)
            {
                for (int i = 0; i < DailySchedule.Count; i++)
                {
                    if (i < DailySchedule.Count - 1)
                        FreeTime.Add(new TimeInterval(DailySchedule[i].EndTime, DailySchedule[i + 1].StartTime));
                    else
                        FreeTime.Add(new TimeInterval(DailySchedule[i].EndTime, WorkingTime.EndTime));
                }
            }
            else
            {
                FreeTime.Add(WorkingTime);
            }
            return FreeTime;
        }
    }
}
