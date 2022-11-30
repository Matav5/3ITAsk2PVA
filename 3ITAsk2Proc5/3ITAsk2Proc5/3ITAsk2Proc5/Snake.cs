using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ITAsk2Proc5
{
    internal class Snake
    {
        public int poleX;
        public int poleY;

        public int smerX = 1;
        public int smerY = 0;
        public Snake(int x, int y)
        {
            this.poleX = x;
            this.poleY = y;
        }

        internal void ChangeSmer(int smerX, int smerY)
        {
            this.smerX = smerX;
            this.smerY = smerY;
        }

        internal void Move()
        {
            poleX += smerX;
            poleY += smerY;
        }
    }
}
