using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming.Model.Classes
{
    internal class Point2D
    {
        private int _x;
        private int _y;

        public int X
        {
            get { return _x; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _x = value;
            }
        }
        
        public int Y
        {
            get { return _y; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _y = value;
            }
        }

        public Point2D(int x, int y)
        {
            Y = y;
            X = x;
        }
        public Point2D() { }
    }
}
