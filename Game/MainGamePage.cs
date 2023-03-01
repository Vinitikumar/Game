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
        private List<Circle> Snake2 = new List<Circle>();
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
                for (int i = 1; i < Snake2.Count; i++)
                {
                    if (i == 1)
                    {
                        snakeColour = Brushes.Blue;
                    }
                    else
                    {
                        snakeColour = Brushes.BlueViolet;
                    }
                    canvas.FillEllipse(snakeColour,
                                        new Rectangle(
                                            Snake2[i].X * Settings.Width,
                                            Snake2[i].Y * Settings.Height,
                                            Settings.Width, Settings.Height
                                            ));

                    canvas.FillEllipse(Brushes.GreenYellow,
                                        new Rectangle(
                                            food.X * Settings.Width,
                                            food.Y * Settings.Height,
                                            Settings.Width, Settings.Height
                                            ));
                }
            }
            else
            {

                string gameOver = "Game Over! " + "Final Score is " + Settings.Score + "\n Press enter to Restart \n";
                label3.Text = gameOver;
                label3.Visible = true;
            }
        }


        private void startGame()
        {
            label3.Visible = false;
            new Settings();
            Snake.Clear();
            Snake2.Clear();
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);
            Snake2.Add(head);

            label3.Text = Settings.Score.ToString();

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

        private void movePlayer2()
        {
            for (int i = Snake2.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Directions.Right:
                            Snake2[i].X++;
                            break;
                        case Directions.Left:
                            Snake2[i].X--;
                            break;
                        case Directions.Up:
                            Snake2[i].Y--;
                            break;
                        case Directions.Down:
                            Snake2[i].Y++;
                            break;
                    }

                    int maxXpos = pbCanvas.Size.Width / Settings.Width;
                    int maxYpos = pbCanvas.Size.Height / Settings.Height;

                    if (
                        Snake2[i].X < 0 || Snake2[i].Y < 0 ||
                        Snake2[i].X > maxXpos || Snake2[i].Y > maxYpos
                        )
                    {

                        die();
                    }

                    for (int j = 1; j < Snake2.Count; j++)
                    {
                        if (Snake2[i].X == Snake2[j].X && Snake2[i].Y == Snake2[j].Y)
                        {
                            die();
                        }
                    }

                    if (Snake2[0].X == food.X && Snake2[0].Y == food.Y)
                    {
                        eat();
                    }

                }
                else
                {
                    Snake2[i].X = Snake2[i - 1].X;
                    Snake2[i].Y = Snake2[i - 1].Y;
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
            Circle body2 = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y

            };

            Snake.Add(body);
            Snake.Add(body2);
            Settings.Speed++;
            Settings.Score += Settings.Points;
            label3.Text = Settings.Score.ToString();
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

                if (Input.KeyPress(Keys.Enter))
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

        private void updateScreen2(object sender, EventArgs e)
        {

            if (Settings.GameOver == true)
            {

                if (Input.KeyPress(Keys.Enter))
                {
                    startGame();
                }
            }
            else
            {

                if (Input.KeyPress(Keys.D) && Settings.direction != Directions.Left)
                {
                    Settings.direction = Directions.Right;
                }
                else if (Input.KeyPress(Keys.A) && Settings.direction != Directions.Right)
                {
                    Settings.direction = Directions.Left;
                }
                else if (Input.KeyPress(Keys.W) && Settings.direction != Directions.Down)
                {
                    Settings.direction = Directions.Up;
                }
                else if (Input.KeyPress(Keys.S) && Settings.direction != Directions.Up)
                {
                    Settings.direction = Directions.Down;
                }

                movePlayer2();

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
    }
}