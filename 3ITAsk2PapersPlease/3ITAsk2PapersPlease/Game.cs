namespace _3ITAsk2PapersPlease
{
    public partial class Game : Form
    {
        public List<string> jmena = new List<string>()
        {
            "Viktor", "Antonín (ale můžete mi říkat Tonda)", "Johana",  "Filištýn", "Reinhardt", "Grizelda", "Generál/ka"
        };
        public List<string> prijmeni = new List<string>()
        {
            "Vendolský", "VVerner", "Ze Skalice",  "Lucemburg", "Kazymír", "Pavel"
        };
        public List<string> statniObcanstvi = new List<string>()
        {
            "Spojené Království Chlumce a Přestanova", "Artozska", "Osvobozenecká Republika Ústeckého Kraje", "Polsko 💀"
        };
        private int _pocetBodu = 0;

        public int PocetBodu
        {
            get => _pocetBodu;
            set
            {
                _pocetBodu = value;
                UpdateBody();
            }
        }
        public Game()
        {
            StatniHraniceManager.Instance.PridaniZakazanychInformaci(jmena, prijmeni, statniObcanstvi);
            InitializeComponent();
            label3.Text = StatniHraniceManager.Instance.VypisPravidel();
            VytvoritDoklad();
            StatniHraniceManager.Instance.onZkontrolovano += OnZkontrolovano;
        }
        private void UpdateBody()
        {
            label1.Text = "Počet bodů: " + PocetBodu;
        }
        private void OnZkontrolovano(Doklad doklad, bool jeSpravne)
        {
            if (jeSpravne)
                PocetBodu++;
            else
                PocetBodu--;
            flowLayoutPanel1.Controls.Remove(doklad);
            VytvoritDoklad();
        }

        private void VytvoritDoklad()
        {
            Random r = new Random();

            Doklad doklad = new Doklad(
                jmena[r.Next(0,jmena.Count)],
                prijmeni[r.Next(0, prijmeni.Count)],
                new DateTime(r.Next(1969,2022),  r.Next(1,13), r.Next(1,32)), 
                r.Next(0,2) == 1,
                statniObcanstvi[r.Next(0, statniObcanstvi.Count)],
                new DateTime(r.Next(2022,2028), r.Next(1, 13), r.Next(1, 32))
                );
            flowLayoutPanel1.Controls.Add(doklad);
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            StatniHraniceManager.Instance.onZkontrolovano -= OnZkontrolovano;
        }
    }
}