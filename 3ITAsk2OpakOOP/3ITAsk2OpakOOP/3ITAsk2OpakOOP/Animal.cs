using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ITAsk2OpakOOP
{
    internal class Animal
    {
        private int ucha;
        public int Ucha { get => ucha; 
            set {
                ucha = value;
                Console.WriteLine("Počet uší je: " + Ucha);
            }
        }
        public string Sound { get; set; }

        public Animal(int ucha, string sound)
        {
            Ucha = ucha;
            Sound = sound;
        }
        public void VolitPrezidenta()
        {
            VolitPrezidenta(true);
        }
        public virtual void VolitPrezidenta(bool vykoristvani)
        {
            if(vykoristvani)
                Console.WriteLine("Život je období dělící se do úseků....");
            Console.WriteLine("Souhlasíte s volbou prezidenta? N/N");
            if (Console.ReadLine() == "N")
            {
                Ucha--;
            }
            else
            {
                Ucha--;
            }
        }
    }
}
