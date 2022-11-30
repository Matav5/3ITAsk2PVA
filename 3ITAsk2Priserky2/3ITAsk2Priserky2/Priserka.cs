using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ITAsk2Priserky2
{
    internal class Priserka
    {
        public Point pozice;
        public Action<Priserka> onSmrt;
        public Priserka(Point pozice)
        {
            this.pozice = pozice;
        }
        public void Vykresli(Graphics g)
        {
            g.FillEllipse(Brushes.DarkGreen, pozice.X - 4, pozice.Y - 4, 8, 8);
        }

        internal void OnThanosSnap()
        {
            Random r = new Random();
            if(r.Next(2) == 0)
            {
                //Příšerka zemře
                if (onSmrt != null)
                    onSmrt.Invoke(this);
            }
        }
    }
}
