namespace _3ITAsk2FridayFunky
{
    public partial class Form1 : Form
    {
        List<Arrow> arrows = new List<Arrow>();
        int currentIndex = 0;
        float timeToLose;
        public Form1()
        {
            InitializeComponent();
            GenerateGame();
        }

        private void GenerateGame()
        {
            Random rand = new Random();
            int arrowCount = rand.Next(6, 11);
            timeToLose = arrowCount;
            for (int i = 0; i < arrowCount; i++)
            {
                int arrowSelect = rand.Next(0, 4);
                switch (arrowSelect)
                {
                    case 0:
                        arrows.Add(new UpArrow(i * 30, 60));
                        break;
                    case 1:
                        arrows.Add(new RightArrow(i * 30, 60));
                        break;
                    case 2:
                        arrows.Add(new DownArrow(i * 30, 60));
                        break;
                    default:
                        arrows.Add(new LeftArrow(i * 30, 60));
                        break;
                }
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Arrow arrow in arrows)
            {
                arrow.Draw(e.Graphics);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (arrows[currentIndex].HandleInput(e))
            {
                if (currentIndex < arrows.Count - 1)
                {
                    arrows[currentIndex].played = true;
                    currentIndex++;
                }
                else if (currentIndex == arrows.Count - 1)
                {
                    arrows[currentIndex].played = true;
                    PlayerWon();
                }

            }
            Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeToLose -= timer1.Interval/1000f;
            if (timeToLose <= 0)
                PlayerLost();
            UpdateTimeLabel();
        }

        private void PlayerLost()
        {
            timer1.Stop();
            if (MessageBox.Show("Jseš nula a neumíš hrát!",
                "Prohrál si seš k ničemu!",
                MessageBoxButtons.OK) == DialogResult.OK)
            {
                PlayerLost();
                PlayerLost();
            }
        }
        private void PlayerWon()
        {
            timer1.Stop();
            if(MessageBox.Show("Jseš nejlepší gamer. Ta vydeo Hra nemjela šancy!",
                "Easy Win",
                MessageBoxButtons.OK) == DialogResult.OK
                )
            {
                Application.Exit();
            }
        }
        private void UpdateTimeLabel()
        {
            label1.Text = "Zbývající čas: " + timeToLose + "s";
        }
    }
}