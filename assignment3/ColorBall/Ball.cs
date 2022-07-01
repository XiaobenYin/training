using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.ColorBall
{
    public class Ball
    {
        private int size;
        private Color color;
        private int numThrown;

        public Ball(int size, int red, int blue, int green, int alpha = 255)
        {
            this.size = size;
            this.color = new Color(red, blue, green, alpha);
            this.numThrown = 0;
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Thrown
        {
            get { return numThrown; }
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size > 0)
            {
                numThrown++;
            }
        }

        public int NumOfThrown()
        {
            return numThrown;
        }
    }
}
