namespace _3ITAsk2Proc2
{
    public partial class Form1 : Form
    {
        Restaurace restaurace;
        public Form1()
        {
            InitializeComponent();
            restaurace = new Restaurace("Los Pollos Hermanos", "Albuquerque", 1998, 100,
            new List<Produkt>()
            {
                new Produkt("Pollo","100% Pollo",2.99f,true),
                new Produkt("Pollo special","99% Pollo with extra spices",49.99f,false)
            }
            );
            UpdateUI();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            restaurace.PridejZakaznika();
            UpdateUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Normální produkt
            if (restaurace.NákupProduktu("Pollo"))
            {
                GetCaught();
            }
            UpdateUI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Produkt speciál
            if (restaurace.NákupProduktu("Pollo special"))
            {
                GetCaught();
            }
            UpdateUI();
        }

        private void GetCaught()
        {
            if (MessageBox.Show($"Naše restaurace {restaurace.name} v {restaurace.lokace} byla chycena při činu. Restaurace vydělala {restaurace.profit}$", "Chycen při činu", MessageBoxButtons.OK) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void UpdateUI()
        {
            label1.Text = $"{restaurace.pocetZakazniku} / {restaurace.kapacitaRestaurace} kapacity";
            label2.Text = $"Profit: {restaurace.profit}$";
        }
    }
}