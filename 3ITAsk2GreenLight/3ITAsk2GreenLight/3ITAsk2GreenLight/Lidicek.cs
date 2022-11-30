using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ITAsk2GreenLight
{
    public class Lidicek
    {
        public string jmeno;
        public PointF pozice;
        public int velikost;
        public int rychlost;
        private bool bezim = true;
        public Action<Lidicek> onSmrt;
        private bool vyhral = false;
        public Lidicek(string jmeno, PointF pozice, int velikost, int rychlost)
        {
            this.jmeno = jmeno;
            this.pozice = pozice;
            this.velikost = velikost;
            this.rychlost = rychlost;
        }
        public void PohniSe(int cilovaCaraY)
        {
            if (bezim)
            {
                pozice.Y += rychlost;
            }
            if(pozice.Y > cilovaCaraY)
            {
                Vyhral();
            }
        }

        private void Vyhral()
        {
            vyhral = true;
            bezim = false;
        }

        public void Vykresli(Graphics g)
        {
            Brush barvicka = vyhral ? Brushes.LawnGreen : Brushes.Black;
            g.DrawRectangle(Pens.White, pozice.X, pozice.Y, 1, 1);
            g.FillEllipse(barvicka, pozice.X - velikost/2, pozice.Y - velikost/2, velikost, velikost);
        }
        public void OnZmenaBarvy(bool jeZelenej)
        {
            if (vyhral)
                return;
            //Rozeběhne se/ umře nebo něco
            Random r = new Random();
            if (r.Next(0,10) > 2) {
                if (jeZelenej)
                {
                    bezim = true;
                }
                else
                {
                    bezim = false;
                }
            }

            if(bezim && !jeZelenej)
            {
                //Umři
                onSmrt?.Invoke(this);
            }
        }
    }
}
