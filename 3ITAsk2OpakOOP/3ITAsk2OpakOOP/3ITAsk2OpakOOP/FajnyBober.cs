using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ITAsk2OpakOOP
{
    internal class FajnyBober : Animal
    {
        public int pocitadloBolestivychUrazek;
        public FajnyBober(int ucha, string sound) : base(ucha, sound)
        {
            sound = "Aký fajný bober. *Goes gryz*";
        }
        public void Gryz()
        {
            Console.WriteLine("Gryz gryz");
        }
        public override void VolitPrezidenta(bool vykoristovani)
        {
            if(vykoristovani)
                Console.WriteLine("By the laws of aviation a bee shouldn't be able to fly it's wings are too small for it's little body...");
            Console.WriteLine("Fajny Bober se stal absolutním vladařem České Republiky... byl nastolen 100 letý mír");
        }
    }
}
