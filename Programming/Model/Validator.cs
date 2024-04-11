using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value)
        {
            if (value <= 0)
                throw new ArgumentException(nameof(value));
        }
        public static void AssertOnPositiveValue(double value)
        {
            if (value <= 0)
                throw new ArgumentException(nameof(value));
        }
        public static void AssertOnPositiveValue(int value, int min, int max)
        {
            if (value < min || value > max)
                throw new ArgumentException(nameof(value));
        }
        public static void AssertOnPositiveValue(double value, double min, double max)
        {
            if (value < min || value > max)
                throw new ArgumentException(nameof(value));
        }
    }
}
