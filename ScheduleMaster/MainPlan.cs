using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaster
{
    internal class MainPlan
    {
        public List<DailyPlan> DailyPlans { get; set; }
        public MainPlan() 
        {
            DailyPlans = new List<DailyPlan>();
        }
        public void AddPlan(DailyPlan plan)
        {
            DailyPlans.Add(plan);
        }
        public void RemovePlan(DailyPlan plan) 
        {  
            DailyPlans.Remove(plan); 
        }
    }
}
