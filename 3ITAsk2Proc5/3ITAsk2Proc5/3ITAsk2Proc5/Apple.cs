using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ITAsk2Proc5
{
    internal class Apple
    {
        public int poleX;
        public int poleY;

        public Color color;
        public Image image;
        public Apple(int x, int y)
        {
            this.poleX = x;
            this.poleY = y;
            color = Color.Red;
            image = Image.FromFile("Apple.png");
        }
    }
}
