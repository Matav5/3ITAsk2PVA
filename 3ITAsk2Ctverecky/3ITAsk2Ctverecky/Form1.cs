namespace _3ITAsk2Ctverecky
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            VytvorCtverecek(e.X,e.Y,e.Button);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void VytvorCtverecek(int x, int y, MouseButtons mouseButtons)
        {
            Ctverecek ctverecek = null;
            if (mouseButtons == MouseButtons.Left)
            {
                 ctverecek = new VtipnyCtverecek();
           
            }
            else if(mouseButtons == MouseButtons.Right)
            {
                 ctverecek = new ZvetsovaciCtverecek();
            }
            if (ctverecek != null) {
                ctverecek.Location = new Point(x - ctverecek.Width / 2, y - ctverecek.Height / 2);
                panel1.Controls.Add(ctverecek);
                button1.MouseClick += ctverecek.Ctverecek_MouseClick;
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}