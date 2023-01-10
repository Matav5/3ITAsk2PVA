using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3ITAsk1_Piskvorky
{
    public partial class Policko : UserControl
    {
        public Hrac Hrac { get; set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        private Policko()
        {
            InitializeComponent();
        }
        public Policko(int x, int y) : this()
        {
            this.X = x;
            this.Y = y;
        }

        private void Policko_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
