using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming
{
    internal class Song
    {
        private string _name;
        private int _duration;
        private string _genre;
        public string Name { get; set; }
        public int Duration
        {
            get { return _duration; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _duration = value;
            }
        }  
        public string Genre { get; set; }

        public Song(string name, int duration, string genre)
        {
            Name = name;
            Duration = duration;
            Genre = genre;
        }
        public Song() { }
    }
}
