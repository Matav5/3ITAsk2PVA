namespace _3ITAsk2GreenLight
{
    public partial class Form1 : Form
    {
        Semafor semafor;
        List<Lidicek> lidicky = new List<Lidicek>();
        List<PointF> seznamMastnejchFleku = new List<PointF>();
        public int cilovaCaraY;
        public Form1()
        {
            InitializeComponent();
            cilovaCaraY = pictureBox1.Height - 20;
            semafor = new Semafor(true, 1);
            CreateNewLidicky();
        }

        private void CreateNewLidicky()
        {
            Lidicek lidicek;
            Random r = new Random();
            for (int i = 0; i < 30; i++)
            {
                lidicek = new Lidicek("Hráč " + (i + 1),
                    new PointF(r.Next(0, pictureBox1.Width), 10),
                    10,
                    r.Next(1, 10)
                    );
                semafor.onZmenaBarvy += lidicek.OnZmenaBarvy;
                lidicek.onSmrt += OnSmrtLidicka;    
                lidicky.Add(lidicek);
            }
        }
        public void OnSmrtLidicka(Lidicek lidicek)
        {
            //Odebrat Lidicka z Listu
            lidicky.Remove(lidicek);
            //Mastnej flek
            seznamMastnejchFleku.Add(lidicek.pozice);
        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            semafor.Vykresli(e.Graphics);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Lidicek lidicek in lidicky)
            {
                lidicek.Vykresli(e.Graphics);
            }
            foreach(PointF poziceFleku in seznamMastnejchFleku)
            {
                e.Graphics.FillEllipse(Brushes.Red,
                    poziceFleku.X,
                    poziceFleku.Y,
                    10,
                    12
                );
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            foreach (Lidicek lidicek in lidicky)
            {
                lidicek.PohniSe(cilovaCaraY);
            }
            semafor.OdectiOdpocet(timer1.Interval);
            Refresh();
        }
    }
}