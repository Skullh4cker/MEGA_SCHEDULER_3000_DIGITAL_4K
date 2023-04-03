using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaster
{
    internal class Scheduler
    {
        // TODO: сделать нормальный алгоритм планировщика. Учесть приоритет задач, загруженность и т.д.
        public static TimeInterval EmbedTask(Task task, List<TimeInterval> freeSpaces)
        {
            TimeInterval time = new TimeInterval();
            var scopeInMinutes = Time.TotalMinutes(task.WorkScope);
            var priority = task.GetPriority();

            freeSpaces = freeSpaces.OrderByDescending(x => x.DifferenceInMinutes).ToList();
            foreach (TimeInterval interval in freeSpaces)
            {
                if (interval.DifferenceInMinutes > scopeInMinutes)
                {
                    time = new TimeInterval(interval.StartTime, new Time(task.WorkScope.Hours + interval.StartTime.Hours, task.WorkScope.Minutes + interval.StartTime.Minutes));
                    break;
                }
            }
            return time;
        }
    }
}
