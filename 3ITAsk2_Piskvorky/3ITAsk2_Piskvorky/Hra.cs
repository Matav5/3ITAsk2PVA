namespace _3ITAsk1_Piskvorky
{
    public partial class Hra : Form
    {
        public Policko[,] HerniPole { get; private set; }
        public Hra()
        {
            InitializeComponent();
            VytvorHerniPole(8);
        }

        private void VytvorHerniPole(int velikost)
        {
            HerniPole = new Policko[velikost, velikost];
            Policko policko;
            //y = i
            //x = j
            int Width = panel1.Width / velikost;
            int Height = panel1.Height / velikost;

            for (int i = 0; i < HerniPole.GetLength(0); i++)
            {
                for (int j = 0; j < HerniPole.GetLength(1); j++)
                {
                    policko = new Policko(j,i);
                    HerniPole[i, j] = policko;
                    panel1.Controls.Add(policko);
                    policko.Width = Width;
                    policko.Height = Height;
                    policko.Location = new Point(Width * j, Height * i );
                }
            }
        }
    }
}