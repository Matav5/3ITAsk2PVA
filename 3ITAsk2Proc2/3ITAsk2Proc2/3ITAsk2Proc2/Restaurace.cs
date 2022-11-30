using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ITAsk2Proc2
{
    internal class Restaurace
    {
        public string name;
        public string lokace;
        public int rokZalozeni;
        public int kapacitaRestaurace;
        public int pocetZakazniku;
        public List<Produkt> produkty;
        public int profit;
        public Restaurace(string name, string lokace, int rokZalozeni, int kapacitaRestaurace, List<Produkt> produkty)
        {
            this.name = name;
            this.lokace = lokace;
            this.rokZalozeni = rokZalozeni;
            this.kapacitaRestaurace = kapacitaRestaurace;
            this.pocetZakazniku = 0;
            this.produkty = produkty;
            this.profit = 0;
        }
        public void PridejZakaznika()
        {
            if (pocetZakazniku < kapacitaRestaurace)
                pocetZakazniku++;
        }

        internal bool NákupProduktu(string jmenoProduktu)
        {
            if (pocetZakazniku <= 0)
                return false;
            Produkt produkt = produkty.Find(x => x.nazev == jmenoProduktu);
            profit += (int)Math.Round(produkt.cena);
            pocetZakazniku--;

            if (!produkt.jeLegalni)
            {
                Random rd = new Random();
                if (rd.Next(0, 101) < 5)
                //Vypnout aplikaci
                {
                    return true;
                }
            }
            return false;
        }
    }
}
