using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaster
{
    #region Enums
    enum Gender
    {
        Male,
        Female
    }
    //TODO: Добавить все типы подзадач по предметной области
    enum Action
    {
        FindTarget,
        TakePhoto,
        Call
    }
    enum Status
    {
        Awaiting,
        Planned,
        Analyzed,
        Performed,
        Completed,
        Failed
    }
    enum Temperament
    {
        Sanguine,
        Choleric,
        Melancholic,
        Phlegmatic
    }
    #endregion

    #region Structs
    struct Difficulty
    {
        private int level = 0;
        public Difficulty(int level)
        {
            Level = level;
        }
        public int Level
        {
            get => level;
            set { if (value >= 0 && value <= 9) level = value; }
        }
    }
    struct TimeInterval
    {
        public Time StartTime { get; private set; }
        public Time EndTime { get; private set; }
        public uint DifferenceInMinutes { get; private set; }
        public TimeInterval(string start, string end)
        {
            StartTime = new Time(Convert.ToUInt16(start.Split(':')[0]), Convert.ToUInt16(start.Split(':')[1]));
            EndTime = new Time(Convert.ToUInt16(end.Split(':')[0]), Convert.ToUInt16(end.Split(':')[1]));
            DifferenceInMinutes = Time.GetDifference(StartTime, EndTime);
        }
        public TimeInterval(Time start, Time end)
        {
            StartTime = start;
            EndTime = end;
            DifferenceInMinutes = Time.GetDifference(StartTime, EndTime);
        }
    }
    struct Time
    {
        private uint hours = 0;
        private uint minutes = 0;

        public Time(uint hours, uint minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }
        public string GetTime()
        {
            return $"{Hours}:{Minutes}";
        }
        public static uint GetDifference(Time t1, Time t2)
        {
            uint totalMinutes1 = Time.TotalMinutes(t1);
            uint totalMinutes2 = Time.TotalMinutes(t2);
            uint diffMinutes;
            if(totalMinutes2 > totalMinutes1)
                diffMinutes = totalMinutes2 - totalMinutes1;
            else
                diffMinutes = totalMinutes1 - totalMinutes2;

            uint diffHours = diffMinutes / 60;
            diffMinutes %= 60;

            return Time.TotalMinutes(new Time { Hours = diffHours, Minutes = diffMinutes });
        }
        public static uint TotalMinutes(Time t)
        {
            return t.Hours * 60 + t.Minutes;
        }
        public uint Hours
        {
            get => hours;
            set => hours = value;
        }
        public uint Minutes
        {
            get => minutes;
            set
            {
                if (value < 60) minutes = value;
                else
                {
                    hours += value / 60;
                    minutes = value % 60;
                }
            }
        }
    }
    #endregion
}
