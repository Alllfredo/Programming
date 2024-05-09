using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming
{
    internal class RectangleFactory
    {
        static Random random = new Random();
        static public Rectangle Randomize()
        {

            return new Rectangle(random.Next(1, 100), random.Next(1, 100), "Green", random.Next(1, 471), random.Next(1, 417));
        }
    }
}
