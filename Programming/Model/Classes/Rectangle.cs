using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class Rectangle
    {
        private double _length;
        private double _widght;
        private string _color;
        public double Length
        {
            get { return _length; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
                _length = value;
            }
        }
        public double Widght
        {
            get { return _widght; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
                _widght = value;
            }
        }
        public string Color
        {
            get { return _color; }
            set
            {
                if (int.TryParse(value, out var intResult))
                {
                    throw new ArgumentException();
                }
                if (!Enum.TryParse<Color>(value, out var color))
                    throw new ArgumentException();
                _color = value;
            }
        }

        public Rectangle(double length, double widght, string color)
        {
            Length = length;
            Widght = widght;
            Color = color;
        }
        public Rectangle() { }
    }
}
