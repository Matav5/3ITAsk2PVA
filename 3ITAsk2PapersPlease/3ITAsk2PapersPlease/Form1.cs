namespace _3ITAsk2PapersPlease
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
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
    }
}