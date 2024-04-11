using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Point2D
    {
        private readonly int _x;
        private readonly int _y;

        public int X
        {
            get { return _x; }
            private set
            {
                Validator.AssertOnPositiveValue(value);
            }
        }

        public int Y
        {
            get { return _x;  }
            private set
            { 
                Validator.AssertOnPositiveValue(value);
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
