using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class Flight
    {
        private string _pointStart;
        private string _pointEnd;
        private int _time;
        public string PointStart { get; set; }
        public string PointEnd { get; set; }
        public int Time
        {
            get { return _time; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _time = value;
            }
        }
        public Flight(string pointStart, string pointEnd, int time)
        {
            PointStart = pointStart;
            PointEnd = pointEnd;
            Time = time;
        }
        public Flight() { }
    }
}
