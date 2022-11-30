using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ITAsk2FridayFunky
{
    internal abstract class Arrow
    {
        public float x;
        public float y;
        public bool played = false;
        public Brush ArrowColor => played ? Brushes.Peru : Brushes.Black;
        public Arrow(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract void Draw(Graphics g);

        public abstract bool HandleInput(KeyEventArgs e);
    }
}
