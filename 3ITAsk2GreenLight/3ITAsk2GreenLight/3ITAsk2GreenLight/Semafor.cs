using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ITAsk2GreenLight
{
    internal class Semafor
    {
        public bool jeZelenej;
        public float casDoZmeny;

        private float width = 200;
        private float height = 100;
        public event Action<bool> onZmenaBarvy;
        public Semafor(bool jeZelenej, float casDoZmeny)
        {
            this.jeZelenej = jeZelenej;
            this.casDoZmeny = casDoZmeny;
        }
        public void ZmenaBarvy()
        {
            jeZelenej = !jeZelenej;
            Random r = new Random();
            casDoZmeny = (float)(r.NextDouble() * 2 + 0.5);
            if (onZmenaBarvy != null)
                onZmenaBarvy.Invoke(jeZelenej);
        }
        public void Vykresli(Graphics g)
        {
            if (jeZelenej)
            {
                g.FillEllipse(Brushes.DarkRed, 0, 0, width / 2, height);
                g.FillEllipse(Brushes.Lime, width / 2, 0, width / 2, height);
            }
            else
            {
                g.FillEllipse(Brushes.Red, 0, 0, width / 2, height);
                g.FillEllipse(Brushes.DarkGreen, width / 2, 0, width / 2, height);
            }
        }

        internal void OdectiOdpocet(int interval)
        {
            casDoZmeny -= interval / 1000f;
            if(casDoZmeny <= 0)
            {
                ZmenaBarvy();
            }
        }
    }
}
