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
    public partial class ZvetsovaciCtverecek : Ctverecek
    {
        public ZvetsovaciCtverecek()
        {
            InitializeComponent();
        }
        public override void Ctverecek_MouseClick(object sender, MouseEventArgs e)
        {
            base.Ctverecek_MouseClick(sender, e);
            if(e.Button == MouseButtons.Left)
            {
                Size += new Size(5, 5);
                Location -= new Size(5/2,5/2);
            }
            else if(e.Button == MouseButtons.Right)
            {
                Size -= new Size(5, 5);
                Location += new Size(5 / 2, 5 / 2);
            }
        }
    }
}
