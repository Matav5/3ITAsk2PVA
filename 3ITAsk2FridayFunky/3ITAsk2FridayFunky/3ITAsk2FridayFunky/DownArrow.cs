using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ITAsk2FridayFunky
{
    internal class DownArrow : Arrow
    {
        public DownArrow(float x, float y) : base(x, y)
        {
        }

        public override void Draw(Graphics g)
        {
            PointF[] bodiky = new PointF[3];
            bodiky[0] = new PointF(x - 10, y);
            bodiky[1] = new PointF(x + 10, y);
            bodiky[2] = new PointF(x, y + 10);
            g.FillPolygon(ArrowColor, bodiky);
        }
        public override bool HandleInput(KeyEventArgs e)
        {
            return e.KeyCode == Keys.S || e.KeyCode == Keys.Down;
        }
    }
}
