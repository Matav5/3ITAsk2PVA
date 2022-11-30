using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ITAsk2Proc5
{
    internal class PoisonedApple : Apple
    {
        public PoisonedApple(int x, int y) : base(x, y)
        {
            image = Image.FromFile("PoisonedApple.png");
        }
    }
}
