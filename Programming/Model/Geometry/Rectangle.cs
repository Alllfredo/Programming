using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;
using Programming.Model.Classes;

namespace Programming
{
    internal class Rectangle
    {
        private int _length;
        private int _widght;
        private string _color;
        private Point2D _center;
        private static int _allRectanglesCount =0;
        private int _id;
        public int Length
        {
            get { return _length; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _length = value;
            }
        }
        
        public int Widght
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

        public int AllRectanglesCount
        {
            get {return _allRectanglesCount;}
        }

        public int Id
        {
            get { return _id; } 
        }

        public Rectangle(int length, int widght, string color, int X, int Y)
        {
            Length = length;
            Widght = widght;
            Color = color;
            Center = new Point2D(X,Y);
            _id = _allRectanglesCount;
            _allRectanglesCount++;
        }
        public Rectangle() { }

        public override string ToString()
        {
            return $"{Id}: (X={Center.X}; Y={Center.Y}; H={_length}; W={_widght})";
        }
    }
}
