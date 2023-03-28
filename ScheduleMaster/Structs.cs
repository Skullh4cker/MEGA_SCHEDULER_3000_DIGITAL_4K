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
        Female,
        AttackHelicopterTigerEC665
    }
    //TODO: Добавить все типы подзадач по предметной области
    enum Action
    {
        BuildHouse,
        TakePhoto,
        TakeVideo,
        WriteDown,
        Pizdec
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
            set { if (value >= 0 && value <= 9) level = value; }
            get => level;
        }
    }

    struct WorkScope
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
    #endregion
}
