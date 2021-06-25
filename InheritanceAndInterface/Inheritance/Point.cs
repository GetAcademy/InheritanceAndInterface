using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterface.Inheritance
{
    class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(string x, string y)
        : this(Convert.ToInt32(x), Convert.ToInt32(y))
        {
        }


        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }
}
