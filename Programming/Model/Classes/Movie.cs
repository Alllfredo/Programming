using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming
{
    internal class Movie
    {
        private string _name;
        private int _time;
        private int _data;
        private string _genre;
        private double _raiting;

        public string Name { get;set; }
        public int Time
        {
            get { return _time; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _time = value;
            }
        }
        public int Data
        {
            get { return _data; }
            set
            {
                Validator.AssertOnPositiveValue(value, 1900, 2024);
                _data = value;
            }
        }
        public string Genre
        {
            get { return _genre; }
            set
            {
                if (int.TryParse(value, out var intResult))
                {
                    throw new ArgumentException();
                }
                if (!Enum.TryParse<Genre>(value, out var genre))
                    throw new ArgumentException();
                _genre = value;
            }
        }
        public double Raiting
        {
            get { return _raiting; }
            set
            {
                Validator.AssertOnPositiveValue(value, 0, 10);


                _raiting = value;
            }
        }
        public Movie(string name,int time, int data, string genre, double raiting)
        {
            Name = name;
            Time = time;
            Data = data;
            Genre = genre;
            Raiting = raiting;
        }
        public Movie() { }
    }
}
