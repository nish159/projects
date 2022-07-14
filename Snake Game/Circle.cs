using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Constructor always has the same name as the class
        public Circle()
        {
            X = 0;
            Y = 0;
        }
    }
}
