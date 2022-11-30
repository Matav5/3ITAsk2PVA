using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ITAsk2Proc2
{
    internal class Produkt
    {
        public string nazev;
        public string slozeni;
        public float cena;
        public bool jeLegalni;

        public Produkt(string nazev, string slozeni, float cena, bool jeLegalni)
        {
            this.nazev = nazev;
            this.slozeni = slozeni;
            this.cena = cena;
            this.jeLegalni = jeLegalni;
        }
    }
}
