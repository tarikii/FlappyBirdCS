namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 7;
        int gravity = 3;
        int score = 0;
        int pipeWidth = 0;
        bool gameOver = false;

        public Form1()
        {
            InitializeComponent();
            pipeWidth = pipeDown.Width;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeDown.Left -= pipeSpeed;
            pipeUp.Left -= pipeSpeed;
            scoreLabel.Text = "Score: " + score.ToString();

            if (pipeDown.Left < -pipeWidth) // Verificar si el tubo más a la izquierda está fuera de la pantalla
            {
                pipeDown.Left = pipeUp.Left = this.Width; // Colocar el tubo en la posición más a la derecha
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeUp.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeDown.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top < 0)
            {
                endGame();
            }

            if (score > 10)
            {
                pipeSpeed = 15;
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = -7;
                flappyBird.Top += gravity;
            }

        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 3;
            }

            if (e.KeyCode == Keys.R && gameOver)
            {
                restartGame();
            }

        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreLabel.Text += " Game Over! :( . Press R to Restart!";
            gameOver = true;
        }

        private void restartGame()
        {
            gameOver = false;
            flappyBird.Location = new Point(66, 173);
            pipeDown.Left = this.Width;
            pipeUp.Left = this.Width;

            score = 0;
            pipeSpeed = 7;
            scoreLabel.Text = "Score: 0";
            gameTimer.Start();

        }
    }
}