using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3ITAsk2Ctverecky
{
    public partial class VtipnyCtverecek : Ctverecek
    {
        public List<string> seznamVtipu = new List<string>()
        {
            "Šli dva a prostřední upadl",
            "Přijde kůň do banky a zeptá se. Můžu si založit koňto?",
            "Víte co řekne programátor když dostane error v Pythonu?\r\n\r\nAjta Krajta"
        };
        public VtipnyCtverecek()
        {
            InitializeComponent();
            ZmenVtip();
            label1.MouseClick += Ctverecek_MouseClick;
        }
        public override void Ctverecek_MouseClick(object sender, MouseEventArgs e)
        {
            base.Ctverecek_MouseClick(sender, e);
            ZmenVtip();

        }
        public void ZmenVtip()
        {
            Random r = new Random();
            label1.Text = seznamVtipu[r.Next(seznamVtipu.Count)];
        }
    }
}
