﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class Discipline
    {
        private string _subject;
        private string _professor;
        private int _grade;
        public string Subject { get; set; }
        public string Professor { get; set; }

        public int Grade
        {
            get { return _grade; }
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentException();
                }
                _grade = value;
            }
        }
        public Discipline(string subject, string professor, int grade)
        {
            Subject = subject;
            Professor = professor;
            Grade = grade;
        }

        public Discipline() { }
    }
}