using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming
{
    internal class Rectangle
    {
        private double _length;
        private double _widght;
        private string _color;
        private Point2D _center;
        public double Length
        {
            get { return _length; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _length = value;
            }
        }
        public double Widght
        {
            get { return _widght; }
            set
            {
                Validator.AssertOnPositiveValue(value);
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

        public Point2D Center { get; set; }

        public Rectangle(double length, double widght, string color, Point2D center)
        {
            Length = length;
            Widght = widght;
            Color = color;
            Center = center;

        }
        public Rectangle() { }
    }
}
