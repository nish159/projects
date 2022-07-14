using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Settings
    {
        public static int Width { get; set; }

        public static int Height { get; set; }

        public static string directions;

        public Settings()
        {
            Width = 17;
            Height = 17;
            // Default direction
            directions = "left";
        }
    }
}
