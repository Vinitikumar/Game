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
    public partial class MainGameForm : Form
    {
        private List<Circle> GreenSnake = new List<Circle>(); // Erstellung eines Listen-Arrays für die Schlange ("Snake")
        private Circle food = new Circle(); // Erstellen einer einzelnen Circle-Klasse namens "food"
        private List<Circle> BlueSnake = new List<Circle>();


        Boolean startedMP = false;
        Boolean startedSP = false;

        int currentKeyPressedMainGamePage = -1;
        public MainGameForm()
        {
            InitializeComponent();

            new Settings(); // Verknüpfung der "Settings"-Klasse mit dem Form

            gameTimer.Interval = 1500 / Settings.Speed; // Ändeern der Spielzeit auf "Settings-Klasse" mit dem Form
            gameTimer.Tick += updateScreenSPMP; // Verknüpfung einer "updateScreenSPMP-Funkton" mit dem Timer
            gameTimer.Tick += updateScreenSP;
            gameTimer.Start(); // Timer starten

            startGame(); // "startGame-Funktion" ausführen
        }
        private void startButton_Click_1(object sender, EventArgs e)
        {
            tabController.SelectedTab = PlayerChoicePage; // nach klicken der "startButton" wird die Seite
                                                          // mit den Optionen der player choices geöffnet
        }
        private void singlePlayerButton_Click(object sender, EventArgs e)
        {
            startedSP = true;
            tabController.SelectedTab = SPAndMPGame; // nach klicken der "SinglePlayerButton" wird
                                                // die "Singleplayer" Seite geöffnet
        }
        private void multiplayerButton_Click(object sender, EventArgs e)
        {
            startedMP = true;
            tabController.SelectedTab = SPAndMPGame; // nach klicken der "SinglePlayerButton" wird
                                                    // die "Multiplayer" Seite geöffnet
        }
        private void updateGraphics(object sender, PaintEventArgs e)
        {
            // Bewegung der Schlange und ihre Teile
            Graphics canvas = e.Graphics; // eine neue "Graphics"-Klasse namens "canvas" wird erstellt

            if (Settings.GameOver == false)
            {
                // wenn das Spiel noch nicht vorbei ist, passiert folgendes
                Brush snakeColour; 

                
                for (int i = 0; i < GreenSnake.Count; i++)
                {
                    if (i == 0)
                    {
                        snakeColour = Brushes.LimeGreen;
                    }
                    else
                    {
                        snakeColour = Brushes.ForestGreen;
                    }
                    canvas.FillEllipse(snakeColour,
                    new Rectangle(
                    GreenSnake[i].X * Settings.Width,
                    GreenSnake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));

                    canvas.FillEllipse(Brushes.Red,
                    new Rectangle(
                    food.X * Settings.Width,
                    food.Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
                }

                if (startedMP)
                {
                    for (int i = 0; i < BlueSnake.Count; i++)
                    {
                        if (i == 0)
                        {
                            snakeColour = Brushes.LightBlue;
                        }
                        else
                        {
                            snakeColour = Brushes.DarkTurquoise;
                        }
                        canvas.FillEllipse(snakeColour,
                        new Rectangle(
                        BlueSnake[i].X * Settings.Width,
                        BlueSnake[i].Y * Settings.Height,
                        Settings.Width, Settings.Height
                        ));
                    }
                }
            }
            else
            {
                string gameOver = "Game Over!";
                string finalScoreGreenSnake = "Final Score" + "\nGreenSnake: " + Settings.Player1Score;
                string finalScoreBlueSnake = "BlueSnake: " + Settings.Player2Score;
                string restartGame = "Press enter to Restart";
                GameOverText.Text = gameOver;
                RestartGameText.Text = restartGame;
                FinalScoreGreenSnakeText.Text = finalScoreGreenSnake;
                FinalScoreBlueSnakeText.Text = finalScoreBlueSnake;

                GameOverText.Visible = true;
                RestartGameText.Visible = true;
                FinalScoreGreenSnakeText.Visible = true;
                if (startedSP)
                {
                    FinalScoreBlueSnakeText.Visible = false;
                }
                else if (startedMP)
                {
                    FinalScoreBlueSnakeText.Visible = true;
                }

            }
        }

        private void startGame()
        {
            GameOverText.Visible = false;
            RestartGameText.Visible = false;
            FinalScoreGreenSnakeText.Visible = false;
            FinalScoreBlueSnakeText.Visible = false;

            new Settings();

            GreenSnake.Clear();
            BlueSnake.Clear();
            Circle head = new Circle { X = 35, Y = 5 };
            Circle head2 = new Circle { X = 10, Y = 5 };
            GreenSnake.Add(head);
            BlueSnake.Add(head2);


            ScoreCountGreen.Visible = true;
            ScoreLabelGreen.Visible = true;
            ScoreCountGreen.Text = Settings.Player1Score.ToString();

            if (startedSP)
            {
                ScoreCountBlue.Visible = false;
                ScoreLabelBlue.Visible = false;
            }
            else if (startedMP)
            {
                ScoreCountBlue.Visible = true;
                ScoreLabelBlue.Visible = true;
            }
            ScoreCountBlue.Text = Settings.Player2Score.ToString();


            generateFood();
        }

        private void movePlayer1()
        {
            // die Hauptschleife für Schlangenkop und-teile
            for (int i = GreenSnake.Count - 1; i >= 0; i--)
            {
                // wenn der Schlangenkopf aktiv ist
                if (i == 0)
                {
                    // den Rest des Körpers bewegen, je nachdem, in welche Richting sich der Kopf bewegt
                    switch (Settings.directionGreenSnake)
                    {
                        case Directions.Right:
                            GreenSnake[i].X++;
                            break;
                        case Directions.Left:
                            GreenSnake[i].X--;
                            break;
                        case Directions.Up:
                            GreenSnake[i].Y--;
                            break;
                        case Directions.Down:
                            GreenSnake[i].Y++;
                            break;
                    }
                    // die Schlange davon abhalen, die "Canvas" zu verlassen
                    int maxXpos = pbCanvas.Size.Width / Settings.Width;
                    int maxYpos = pbCanvas.Size.Height / Settings.Height;

                    if (
                    GreenSnake[i].X < 0 || GreenSnake[i].Y < 0 ||
                    GreenSnake[i].X > maxXpos || GreenSnake[i].Y > maxYpos
                    )
                    {
                        // Ende des Spiels ist Schlage erreicht entweder Kante der "Canvas"
                        Console.WriteLine("Collision with border, GreenSnake");
                        die();
                    }
                    // Kollision mit dem Körper erkennen
                    // diese Schleife prüft, ob die Schlange eine Kollision mit anderen Körperteilen hatte
                    for (int j = 1; j < GreenSnake.Count; j++)
                    {
                        if (GreenSnake[i].X == GreenSnake[j].X && GreenSnake[i].Y == GreenSnake[j].Y)
                        {
                            // wenn ja, wird die Funktion "die()" gestartet
                            Console.WriteLine("Collision with body");
                            die();
                        }
                    }
                    // KOllision zwischen Schlangenkopf und "food" erkennen
                    if (GreenSnake[0].X == food.X && GreenSnake[0].Y == food.Y)
                    {
                        eat();
                    }
                }
                else
                {
                    // wenn es keine Kollisionen gibt, bewegt die Schlange ubd ihre Teile weiter
                    GreenSnake[i].X = GreenSnake[i - 1].X;
                    GreenSnake[i].Y = GreenSnake[i - 1].Y;
                }
            }
        }
        private void movePlayer2()
        {
            if (startedSP)
            {
                return;
            }

            for (int i = BlueSnake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.directionBlueSnake)
                    {
                        case Directions.Right:
                            BlueSnake[i].X++;
                            break;
                        case Directions.Left:
                            BlueSnake[i].X--;
                            break;
                        case Directions.Up:
                            BlueSnake[i].Y--;
                            break;
                        case Directions.Down:
                            BlueSnake[i].Y++;
                            break;
                    }

                    int maxXpos = pbCanvas.Size.Width / Settings.Width;
                    int maxYpos = pbCanvas.Size.Height / Settings.Height;

                    if (
                    BlueSnake[i].X < 0 || BlueSnake[i].Y < 0 ||
                    BlueSnake[i].X > maxXpos || BlueSnake[i].Y > maxYpos
                    )
                    {
                        Console.WriteLine("Collision with borders, BlueSnake");
                        die();
                    }
                    for (int j = 1; j < BlueSnake.Count; j++)
                    {
                        if (BlueSnake[i].X == BlueSnake[j].X && BlueSnake[i].Y == BlueSnake[j].Y)
                        {
                            Console.WriteLine("Collision with body, snake 2");
                            die();
                        }
                    }
                    if (BlueSnake[0].X == food.X && BlueSnake[0].Y == food.Y)
                    {
                        eat2();
                    }
                }
                else
                {
                    BlueSnake[i].X = BlueSnake[i - 1].X;
                    BlueSnake[i].Y = BlueSnake[i - 1].Y;
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
                X = GreenSnake[GreenSnake.Count - 1].X,
                Y = GreenSnake[GreenSnake.Count - 1].Y
            };

            GreenSnake.Add(body);

            Settings.Speed++;
            Settings.Player1Score += Settings.Points;
            ScoreCountGreen.Text = Settings.Player1Score.ToString();
            generateFood();
        }
        private void eat2()
        {
            Circle body2 = new Circle
            {
                X = BlueSnake[BlueSnake.Count - 1].X,
                Y = BlueSnake[BlueSnake.Count - 1].Y
            };

            BlueSnake.Add(body2);

            Settings.Speed++;
            Settings.Player2Score += Settings.Points;
            ScoreCountBlue.Text = Settings.Player2Score.ToString();
            generateFood();
        }
        private void die()
        {
            Settings.GameOver = true;
        }
        private void updateScreenSPMP(object sender, EventArgs e)
        {
            // das ist die "timer-updateScreen" Funktion
            // jedes tick führt diese Funktion aus
            if (Settings.GameOver == true)
            {
                // wenn das Spiel vorbei ist nd der Spieler die Eingabetaste drückt
                // starten wir die Spielfunktion
                if (currentKeyPressedMainGamePage == (int)Keys.Enter)
                {
                    startGame();
                }
                // wenn das Spiel nicht zu Ende ist, werden folgende Befehle ausgeführt
                // unterhalb der Aktionen werden die "keys", die vom Spieler gedrückt werden, sondiert
                // und bewegen sich entsprechend
                else if (currentKeyPressedMainGamePage == (int)Keys.Escape)
                {
                    tabController.SelectedTab = PlayerChoicePage;
                    startedSP = false;
                    startGame();
                }
            }
            else if (currentKeyPressedMainGamePage != -1)
            {
                if (currentKeyPressedMainGamePage == (int)Keys.Right)
                {
                    Settings.directionGreenSnake = Directions.Right;
                }
                else if (currentKeyPressedMainGamePage == (int)Keys.Left)
                {
                    Settings.directionGreenSnake = Directions.Left;
                }
                else if (currentKeyPressedMainGamePage == (int)Keys.Up)
                {
                    Settings.directionGreenSnake = Directions.Up;
                }
                else if (currentKeyPressedMainGamePage == (int)Keys.Down)
                {
                    Settings.directionGreenSnake = Directions.Down;
                }
                movePlayer1(); // ausführen "movePlayer"-Funktion
            }
            pbCanvas.Invalidate(); // aktualisiert den "pictureBox" ("pbCanvas")
                                   // und aktualisiert die "graphics" darauf
        }
        private void updateScreenSP(object sender, EventArgs e)
        {
            if (startedSP)
            {
                ScoreLabelBlue.Visible = false;
                ScoreCountBlue.Visible = false;
                FinalScoreBlueSnakeText.Visible = false;
            }
            else if (Settings.GameOver == true)
            {
                if (currentKeyPressedMainGamePage == (int)Keys.Enter)
                {
                    startGame();
                }
                else if (currentKeyPressedMainGamePage == (int)Keys.Escape)
                {
                    tabController.SelectedTab = PlayerChoicePage;
                    startGame();
                }
            }
            else if (currentKeyPressedMainGamePage != -1)
            {
                if (currentKeyPressedMainGamePage == (int)Keys.D)
                {
                    Settings.directionBlueSnake = Directions.Right;
                }
                else if (currentKeyPressedMainGamePage == (int)Keys.A)
                {
                    Settings.directionBlueSnake = Directions.Left;
                }
                else if (currentKeyPressedMainGamePage == (int)Keys.W)
                {
                    Settings.directionBlueSnake = Directions.Up;
                }
                else if (currentKeyPressedMainGamePage == (int)Keys.S)
                {
                    Settings.directionBlueSnake = Directions.Down;
                }
                movePlayer2();
            }
            pbCanvas.Invalidate();
        }
        private void tabController_KeyDown(object sender, KeyEventArgs e)
        {
            if (startedSP)
            {
                updateScreenSPMP(sender, e);
                currentKeyPressedMainGamePage = e.KeyValue;
            }
            else if (startedMP)
            {
                updateScreenSPMP(sender, e);
                updateScreenSP(sender, e);
                currentKeyPressedMainGamePage = e.KeyValue;

            }
            e.Handled = true;
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}
