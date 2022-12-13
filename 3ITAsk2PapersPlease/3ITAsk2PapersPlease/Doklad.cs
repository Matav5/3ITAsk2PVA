using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3ITAsk2PapersPlease
{
    public partial class Doklad : UserControl
    {
        public string jmeno;
        public string prijmeni;
        public DateTime datumNarozeni;
        public bool jeMuz;
        public string statniObcanstvi;
        public DateTime datumExpirace;

        protected Doklad()
        {
            InitializeComponent();
        }
        public Doklad(string jmeno, string prijmeni, DateTime datumNarozeni, bool jeMuz, string statniObcanstvi, DateTime datumExpirace) : this()
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNarozeni = datumNarozeni;
            this.jeMuz = jeMuz;
            this.statniObcanstvi = statniObcanstvi;
            this.datumExpirace = datumExpirace;
            UpdateUI();
        }
        public void UpdateUI()
        {
            label4.Text = jmeno;
            label2.Text = prijmeni;
            label7.Text = datumNarozeni.ToString("d");
            label5.Text = "Pohlaví: " + (jeMuz ? "M" : "Z");
            label10.Text = statniObcanstvi;
            label9.Text = datumExpirace.ToString("d");
        }

    }
}
