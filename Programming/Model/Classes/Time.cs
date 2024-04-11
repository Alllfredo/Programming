using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class Time
    {
        private int _hour;
        private int _minute;
        private int _second;
        public int Hour
        {
            set
            {
                if (0 > value || value < 24)
                {
                    throw new ArgumentException();
                }
                _hour = value;
                

            }
            get { return _hour; }
        }
        public int Minute
        { 
            set
            {
                if (0 > value || value < 60)
                    throw new ArgumentException();
                _minute = value;
            }
            get { return _minute; }
        }
        public int Second
        {
            set
            {
                if (0 > value || value < 60)
                    throw new ArgumentException();
                _second = value;
            }
            get { return _second; }
        }

        public Time(int hour,int minute,int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        public Time() { }
    }
}
