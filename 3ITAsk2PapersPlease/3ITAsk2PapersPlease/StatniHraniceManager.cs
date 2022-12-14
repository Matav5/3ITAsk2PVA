using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ITAsk2PapersPlease
{
    internal class StatniHraniceManager
    {
        private static StatniHraniceManager _instance;
        public static StatniHraniceManager Instance
        {
            get
            {   if (_instance == null)
                    _instance = new StatniHraniceManager();
                return _instance;
            }
        }

        public List<string> seznamZakazanychJmen = new List<string>();
        public List<string> seznamZakazanychPrijmeni = new List<string>();
        public List<string> seznamZakazanychZemi = new List<string>();
        public int maximalniVek = 55;
        public bool zakazanyPohlavek = false;

        public StatniHraniceManager()
        {

        }
        public void PridaniZakazanychInformaci(List<string> seznamJmen, List<string> seznamPrijmeni, List<string> seznamZemi)
        {
            PridatDoZakazanych(seznamJmen,seznamZakazanychJmen);
            PridatDoZakazanych(seznamPrijmeni,seznamZakazanychPrijmeni);
            PridatDoZakazanych(seznamZemi,seznamZakazanychZemi);
        }
        public void PridatDoZakazanych(List<string> seznam, List<string> seznamZakazanych)
        {
            Random r = new Random();
            for (int i = 0; i < 2; i++)
            {
                string jmeno = seznam[r.Next(seznam.Count)];
                if (!seznamZakazanych.Contains(jmeno))
                    seznamZakazanych.Add(jmeno);
                else
                    i--;
            }
        }
        
        public void ZkontrolujDoklad(Doklad dokladKeKontrole, bool jePrijmut)
        {
            if(KontrolaDokladuManagerem(dokladKeKontrole) == jePrijmut)
            {
                MessageBox.Show("Udělal jste to správně. Sláva Stříbrníků");
            }
            else
            {
                MessageBox.Show("Udělal jste to špatně. Stříbrniky se za vás stydí");
            }
        }
        private bool KontrolaDokladuManagerem(Doklad dokladKeKontrole)
        {
            if (seznamZakazanychJmen.Contains(dokladKeKontrole.jmeno))
                return false;
            if (seznamZakazanychPrijmeni.Contains(dokladKeKontrole.prijmeni))
                return false;
            if (seznamZakazanychZemi.Contains(dokladKeKontrole.statniObcanstvi))
                return false;
            if (dokladKeKontrole.datumNarozeni.AddYears(maximalniVek) <= DateTime.Now)
                return false;
            if (dokladKeKontrole.jeMuz == zakazanyPohlavek)
                return false;
            return true;
        }
        public string VypisPravidel()
        {
            string text = "";
            text += "Seznam zakázaných jmen:\n " + string.Join(' ', seznamZakazanychJmen) + "\n";
            text += "Seznam zakázaných příjmení:\n " + string.Join(' ', seznamZakazanychPrijmeni) + "\n";
            text += "Seznam zakázaných zemí:\n " + string.Join(' ', seznamZakazanychZemi) + "\n";
            text += "Maximální věk: " + maximalniVek + "\n";
            text += "Zakázaný p.: " + (zakazanyPohlavek ? "M": "Z")+ "\n";
            return text;
        }
        
    }
}
