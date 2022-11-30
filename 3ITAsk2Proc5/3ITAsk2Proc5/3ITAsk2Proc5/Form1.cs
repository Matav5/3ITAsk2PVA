namespace _3ITAsk2Proc5
{
    public partial class Form1 : Form
    {
        int cellCount = 20;
        Snake snake;
        int cellWidth;
        int cellHeight;
        Apple apple;
        Image image;
        public Form1()
        {
            InitializeComponent();
            snake = new Snake(0, 0);
            cellCount = 20;
            cellWidth = pictureBox1.Width / cellCount;
            cellHeight = pictureBox1.Height / cellCount;
            CreateNewApple();
            image = Image.FromFile("Apple.png");
        }
        private void CreateNewApple()
        {
            Random rnd = new Random();
            apple = new PoisonedApple(rnd.Next(0, cellCount), rnd.Next(0, cellCount));
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Pohyb
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                snake.ChangeSmer(0, -1);
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                snake.ChangeSmer(0, 1);
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                snake.ChangeSmer(-1, 0);
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                snake.ChangeSmer(1, 0);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Aquamarine,
                snake.poleX * cellWidth,
                snake.poleY * cellHeight,
                cellWidth, cellHeight);
            e.Graphics.DrawImage(apple.image, apple.poleX * cellWidth,
                apple.poleY * cellHeight,
                cellWidth,
                cellHeight);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            snake.Move();
            //Kolizi
            CheckForApple();
            FindenSieHerausObEsWegIst();
            Refresh();
        }

        private void FindenSieHerausObEsWegIst()
        {
            if (snake.poleX > cellCount - 1 ||
                snake.poleX < 0 || 
                snake.poleY > cellCount - 1 ||
                snake.poleY < 0)
            {
                //Tak je mimo a chcípne
                घाटा();
            }
        }

        private void घाटा()
        {
            //Prohrál
            timer1.Stop();
            MessageBox.Show("Prohrál jsi", "Meghal!");
            Application.Exit();

        }

        private void CheckForApple()
        {
            if (snake.poleX == apple.poleX && snake.poleY == apple.poleY)
            {
                if (apple is PoisonedApple)
                {
                    घाटा();
                }
                else
                {
                    //Jablíčko se spapá
                    CreateNewApple();
                    timer1.Interval -= 10;
                }
            }
        }
    }
}