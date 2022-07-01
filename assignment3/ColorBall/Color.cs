using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.ColorBall
{
    public class Color
    {
        public Color(int red, int blue, int green, int alpha = 255)
        {
            Red = red;
            Blue = blue;
            Green = green;
            Alpha = alpha;
        }

        public int Red { get; set; }
        public int Blue { get; set; }
        public int Green { get; set; }
        public int Alpha { get; set; }

        public int getGrayscale(int red, int green, int blue)
        {
            int grayscale = (int)(red + blue + green) / 3;
            return grayscale;
        }
    }
}
