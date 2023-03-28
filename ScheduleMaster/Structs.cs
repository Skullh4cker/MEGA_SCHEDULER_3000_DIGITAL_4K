using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaster
{
    //TODO: Добавить все типы подзадач по предметной области
    enum Action
    {
        TakePhoto,
        TakeVideo,
        WriteDown,
        Pizdec
    }
    struct Difficulty
    {

        private int level = 0;
        public Difficulty(int level)
        {
            Level = level;
        }
        public int Level
        {
            set { if (value >= 0 && value <= 9) level = value; }
            get => level;
        }
    }

    public struct WorkScope
    {
        private uint hours = 0;
        private uint minutes = 0;

        public WorkScope(uint hours, uint minutes)
        {
            Hours = hours;
            Minutes = minutes;
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
}
