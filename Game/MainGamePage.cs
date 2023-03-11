using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class MainGamePage : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        Boolean started = false;
        int currentKeyPressedMainGamePage = -1;

        public MainGamePage()
        {
            InitializeComponent();

            new Settings();

            gameTimer.Interval = 1500 / Settings.Speed;
            gameTimer.Tick += updateScreen;
            gameTimer.Start();

            startGame();
        }
        
        private void startButton_Click_1(object sender, EventArgs e)
        {
            started = true;
            tabController.SelectedTab = MainGame;
        }


        private void updateGraphics(object sender, PaintEventArgs e)
        {

            Graphics canvas = e.Graphics;

            if (Settings.GameOver == false)
            {

                Brush snakeColour;

                for (int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                    {
                        snakeColour = Brushes.Red;
                    }
                    else
                    {
                        snakeColour = Brushes.IndianRed;
                    }
                    canvas.FillEllipse(snakeColour,
                                        new Rectangle(
                                            Snake[i].X * Settings.Width,
                                            Snake[i].Y * Settings.Height,
                                            Settings.Width, Settings.Height
                                            ));

                    canvas.FillEllipse(Brushes.DarkGreen,
                                        new Rectangle(
                                            food.X * Settings.Width,
                                            food.Y * Settings.Height,
                                            Settings.Width, Settings.Height
                                            ));
                }

            }
            else
            {

                string gameOver = "Game Over!"; 
                string finalScore = "Final Score" + "\nPlayer1: " + Settings.Player1Score + "\nPlayer2: " + Settings.Player2Score;
                string restartGame = "Press enter to Restart";
                GameOverText.Text = gameOver;
                RestartGameText.Text = restartGame;
                FinalScoreText.Text = finalScore;
                GameOverText.Visible = true;
                RestartGameText.Visible = true;
                FinalScoreText.Visible = true;
            }
        }


        private void startGame()
        {
            GameOverText.Visible = false;
            RestartGameText.Visible = false;
            FinalScoreText.Visible = false;
            new Settings();
            Snake.Clear();
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);

            ScoreCount.Text = Settings.Player1Score.ToString();
            ScoreCount2.Text = Settings.Player2Score.ToString();

            generateFood();
        }

        private void movePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Directions.Right:
                            Snake[i].X++;
                            break;
                        case Directions.Left:
                            Snake[i].X--;
                            break;
                        case Directions.Up:
                            Snake[i].Y--;
                            break;
                        case Directions.Down:
                            Snake[i].Y++;
                            break;
                    }

                    int maxXpos = pbCanvas.Size.Width / Settings.Width;
                    int maxYpos = pbCanvas.Size.Height / Settings.Height;

                    if (
                        Snake[i].X < 0 || Snake[i].Y < 0 ||
                        Snake[i].X > maxXpos || Snake[i].Y > maxYpos
                        )
                    {

                        die();
                    }

                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            die();
                        }
                    }

                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        eat();
                    }

                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }
        private void generateFood()
        {
            int maxXpos = pbCanvas.Size.Width / Settings.Width;
            int maxYpos = pbCanvas.Size.Height / Settings.Height;
            Random rnd = new Random();
            food = new Circle { X = rnd.Next(0, maxXpos), Y = rnd.Next(0, maxYpos) };
        }

        private void eat()
        {
            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y

            };

            Snake.Add(body);

            Settings.Speed++;
            Settings.Player1Score += Settings.Points;
            ScoreCount.Text = Settings.Player1Score.ToString();
            generateFood();
        }
        private void die()
        {
            Settings.GameOver = true;
        }

        private void updateScreen(object sender, EventArgs e)
        {
            if (Settings.GameOver == true)
            {

                if (currentKeyPressedMainGamePage == (int)Keys.Enter)
                {
                    startGame();
                }
            }
            else if (currentKeyPressedMainGamePage != -1)
            {
                if (currentKeyPressedMainGamePage == (int)Keys.Right)
                {
                    Settings.direction = Directions.Right;
                }
                else if (currentKeyPressedMainGamePage == (int)Keys.Left)
                {
                    Settings.direction = Directions.Left;
                }
                else if (currentKeyPressedMainGamePage == (int)Keys.Up)
                {
                    Settings.direction = Directions.Up;
                }
                else if (currentKeyPressedMainGamePage == (int)Keys.Down)
                {
                    Settings.direction = Directions.Down;
                }

                movePlayer();
            }

            pbCanvas.Invalidate();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pbCanvas_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainGame_Click(object sender, EventArgs e)
        {

        }

        private void tabController_Click(object sender, EventArgs e)
        {

        }

        private void StartPage_Click(object sender, EventArgs e)
        {

        }

        private void tabController_KeyDown(object sender, KeyEventArgs e)
        {
            if (started)
            {
                updateScreen(sender, e);
                currentKeyPressedMainGamePage = e.KeyValue;
            }

            e.Handled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}