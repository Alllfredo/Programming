using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

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
                Validator.AssertOnPositiveValue(value,0,24);
                _hour = value;
                

            }
            get { return _hour; }
        }
        public int Minute
        { 
            set
            {
                Validator.AssertOnPositiveValue(value, 0, 60);
                _minute = value;
            }
            get { return _minute; }
        }
        public int Second
        {
            set
            {
                Validator.AssertOnPositiveValue(value, 0, 60);
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
