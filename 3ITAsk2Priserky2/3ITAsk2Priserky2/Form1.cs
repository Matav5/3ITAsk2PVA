namespace _3ITAsk2Priserky2
{
    public partial class Form1 : Form
    {
        List<Priserka> priserky = new List<Priserka>();
        Action onThanosSnap;
        public int pocitadloObeti = 0;
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Priserka priserka;
            Random r = new Random();
            for (int i = 0; i < 50; i++)
            {
                priserka = new Priserka(
                    new Point(r.Next(pictureBox1.Width), r.Next(pictureBox1.Height))
                    );

                onThanosSnap += priserka.OnThanosSnap;
                priserka.onSmrt += OnSmrtPriserky;
                priserky.Add(priserka);
            }
        }

        private void OnSmrtPriserky(Priserka priserka)
        {
            onThanosSnap -= priserka.OnThanosSnap;
            priserky.Remove(priserka);
            pocitadloObeti++;
            label1.Text = "Poèet obìtí: " + pocitadloObeti;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(onThanosSnap != null)
                onThanosSnap.Invoke();
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var priserka in priserky)
            {
                priserka.Vykresli(e.Graphics);
            }
        }
    }
}