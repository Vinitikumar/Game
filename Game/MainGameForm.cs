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

            gameTimer.Interval = 1500 / Settings.Speed; // ändern der Spielzeit auf "Settings-Klasse" mit dem Form
            gameTimer.Tick += updateScreenSPMP; // Verknüpfung einer "updateScreenSPMP-Funkton" mit dem Timer
            gameTimer.Tick += updateScreenSP;
            gameTimer.Start(); // Timer starten

            startGame(); // "startGame-Methode" ausführen
        }
        private void startButton_Click_1(object sender, EventArgs e)
        {
            tabController.SelectedTab = PlayerChoicePage; // nach klicken der "startButton" wird die Seite
                                                          // mit den Optionen der player choices geöffnet
        }
        private void singlePlayerButton_Click(object sender, EventArgs e)
        {
            startedSP = true;
            tabController.SelectedTab = SPAndMPGame; // nach klicken der "Singlepayer-Button" wird
                                                // die "Singleplayer" Seite geöffnet
        }
        private void multiplayerButton_Click(object sender, EventArgs e)
        {
            startedMP = true;
            tabController.SelectedTab = SPAndMPGame; // nach klicken der "Multiplayer-Button" wird
                                                     // die "Multiplayer" Seite geöffnet
        }
        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm(); // nach klicken der "Help-Button" wird
            helpForm.Show();                    // der "Help" Form geöffnet
        }
        private void updateGraphics(object sender, PaintEventArgs e)
        {
            // Bewegung der Schlange und ihre Teile

            Graphics canvas = e.Graphics; // eine neue "Graphics"-Klasse namens "canvas" wird erstellt

            if (Settings.GameOver == false)
            {
                // wenn das Spiel noch nicht vorbei ist, passiert folgendes
                Brush snakeColour; // Erstellung eines neuen Pinsel 

                // die Schleife überprüft die Schlangenteile
                for (int i = 0; i < GreenSnake.Count; i++)
                {
                    if (i == 0)
                    {
                        // färbt den Kopf der Snake1
                        snakeColour = Brushes.LimeGreen;
                    }
                    else
                    {
                        // der Rest des Körpers wird gefärbt
                        snakeColour = Brushes.ForestGreen;
                    }
                    // Zeichnung der Schlangenkörper und Kopf 
                    canvas.FillEllipse(snakeColour,
                    new Rectangle(
                    GreenSnake[i].X * Settings.Width,
                    GreenSnake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
                    // Zeichnung des "foods"
                    canvas.FillEllipse(Brushes.Red,
                    new Rectangle(
                    food.X * Settings.Width,
                    food.Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
                }
                // wenn der Tab mit dem Multiplayermodus gewechselt wird
                // wird der Snake2 sichtbar
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
                // dieser Teil wird ausgeführt, wenn das spiel zu Ende ist
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

        // dies ist die Methode zum Starten des Spiels
        private void startGame()
        {
            GameOverText.Visible = false; // Game over text auf „invisible" setzten
            RestartGameText.Visible = false;
            FinalScoreGreenSnakeText.Visible = false;
            FinalScoreBlueSnakeText.Visible = false;

            new Settings(); // Erstellung einer neuen Instanz von Settings()

            GreenSnake.Clear(); // alle Schlangenteile entfernen
            BlueSnake.Clear();
            Circle head = new Circle { X = 35, Y = 5 }; // Erstellung einer neuen Kopf für die Schlange
            Circle head2 = new Circle { X = 10, Y = 5 };
            GreenSnake.Add(head); // Hinzufügen des Kopfs zum Array der Schlange
            BlueSnake.Add(head2);


            ScoreCountGreen.Visible = true; // anzeigen der score Labels
            ScoreLabelGreen.Visible = true;
            ScoreCountGreen.Text = Settings.Player1Score.ToString();

            // wenn der Multiplayermodus aktiviert wird - sind die labels der Snake2 auch sichtbar
            // ansonsten nicht
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


            generateFood(); // Ausführen der Methode generateFood() 
        }

        private void movePlayer1()
        {
            // die Hauptschleife für Schlangenkopf und -teile
            for (int i = GreenSnake.Count - 1; i >= 0; i--)
            {
                try
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
                        // die Schlange davon abhalten, die "Canvas" zu verlassen
                        int maxXpos = pbCanvas.Size.Width / Settings.Width;
                        int maxYpos = pbCanvas.Size.Height / Settings.Height;

                        if (GreenSnake[i].X < 0 || GreenSnake[i].Y < 0 || GreenSnake[i].X > maxXpos || GreenSnake[i].Y > maxYpos)
                        {
                            // Ende des Spiels ist Schlage erreicht entweder Kante der "Canvas"
                            Console.WriteLine("Collision with border, GreenSnake");
                            die();
                            Console.WriteLine("Game over");
                        }
                        // diese Schleife prüft, ob die Schlange eine Kollision mit anderen Körperteilen hatte
                        for (int j = 1; j < GreenSnake.Count; j++)
                        {
                            if (GreenSnake[i].X == GreenSnake[j].X && GreenSnake[i].Y == GreenSnake[j].Y)
                            {
                                // wenn ja, wird die Methode "die()" gestartet
                                Console.WriteLine("Collision with body");
                                die();
                                Console.WriteLine("Game over");
                            }
                        }

                        // Kollision zwischen Schlangenkopf und "food" erkennen
                        // wenn ja dann "food" fressen
                        if (GreenSnake[0].X == food.X && GreenSnake[0].Y == food.Y)
                        {
                            eat();
                            Console.WriteLine("GreenSnake eats food");
                        }
                    }
                    else
                    {
                        // wenn es keine Kollisionen gibt, bewegt die Schlange und ihre Teile weiter
                        GreenSnake[i].X = GreenSnake[i - 1].X;
                        GreenSnake[i].Y = GreenSnake[i - 1].Y;
                    }
                }
                catch
                {
                    Console.WriteLine("BlueSnake can't move");
                }
            }
        }

        // gleicher Vorgang wie movePlayer1()-Methode
        // aber nur für Singleplayermodus
        private void movePlayer2()
        {
            if (startedSP)
            {
                return;
            }

            for (int i = BlueSnake.Count - 1; i >= 0; i--)
            {
                try
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
                            Console.WriteLine("Game over");
                        }
                        for (int j = 1; j < BlueSnake.Count; j++)
                        {
                            if (BlueSnake[i].X == BlueSnake[j].X && BlueSnake[i].Y == BlueSnake[j].Y)
                            {
                                Console.WriteLine("Collision with body, snake 2");
                                die();
                                Console.WriteLine("Game over");
                            }
                        }
                        if (BlueSnake[0].X == food.X && BlueSnake[0].Y == food.Y)
                        {
                            eat2();
                            Console.WriteLine("GreenSnake eats food");
                        }
                    }
                    else
                    {
                        BlueSnake[i].X = BlueSnake[i - 1].X;
                        BlueSnake[i].Y = BlueSnake[i - 1].Y;
                    }
                }
                catch
                {
                    Console.WriteLine("GreenSnake can't move");
                }

            }
        }

        private void generateFood()
        {
            // Erstellen einer maximale X-Position int mit der halben Größe des Spielbereichs
            int maxXpos = pbCanvas.Size.Width / Settings.Width;
            // Erstellen einer maximale Y-Position int mit der halben Größe des Spielbereichs
            int maxYpos = pbCanvas.Size.Height / Settings.Height;
            Random rnd = new Random(); // Erstellen einer neuen Zufallsklasse
            food = new Circle { X = rnd.Next(0, maxXpos), Y = rnd.Next(0, maxYpos) }; // Erstellen eines neuen "food" mit einem zufälligen X und Y
        }
        private void eat()
        {
            Circle body = new Circle
            {
                X = GreenSnake[GreenSnake.Count - 1].X,
                Y = GreenSnake[GreenSnake.Count - 1].Y
            };

            GreenSnake.Add(body);

            Settings.Speed++; // Hinzufügen des Teils zum Schlangen-Array
            Settings.Player1Score += Settings.Points; // den Punktestand für das Spiel erhöhen
            ScoreCountGreen.Text = Settings.Player1Score.ToString(); // zeigt den Punktestand auf dem "ScoreCountGreen label"
            generateFood(); // die Methode generateFood()
        }

        // gleicher Vorgang wie eat()-Methode
        // aber nur für Singleplayermodus
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
            // Game over Boolean auf true gesetzt
            // Spiel wird beendet
            Settings.GameOver = true;
        }
        private void updateScreenSPMP(object sender, EventArgs e)
        {
            // das ist die "timer-updateScreen" Methode
            // jedes tick führt diese Methode aus
            if (Settings.GameOver == true)
            {
                // wenn das Spiel vorbei ist und der Spieler die Eingabetaste drückt
                // startGame()-Methode wird gestartet
                if (currentKeyPressedMainGamePage == (int)Keys.Enter)
                {
                    startGame();
                    Console.WriteLine("Game started");
                }
                // wenn das Spiel nicht zu Ende ist, werden folgende Befehle ausgeführt
                // unterhalb der Aktionen werden die "keys", die vom Spieler gedrückt werden, sondiert
                // und bewegen sich entsprechend
                else if (currentKeyPressedMainGamePage == (int)Keys.Escape)
                {
                    tabController.SelectedTab = PlayerChoicePage;
                    startedSP = false;
                    startGame();
                    Console.WriteLine("Game started");
                }
                // Vorgang für "Arrow keys"
            }
            else if (currentKeyPressedMainGamePage != -1)
            {
                if (currentKeyPressedMainGamePage == (int)Keys.Right)
                {
                    Settings.directionGreenSnake = Directions.Right;
                    Console.WriteLine("GreenSnake moves to the right");
                }
                else if (currentKeyPressedMainGamePage == (int)Keys.Left)
                {
                    Settings.directionGreenSnake = Directions.Left;
                    Console.WriteLine("GreenSnake moves to the left");
                }
                else if (currentKeyPressedMainGamePage == (int)Keys.Up)
                {
                    Settings.directionGreenSnake = Directions.Up;
                    Console.WriteLine("GreenSnake moves to the upside");
                }
                else if (currentKeyPressedMainGamePage == (int)Keys.Down)
                {
                    Settings.directionGreenSnake = Directions.Down;
                    Console.WriteLine("GreenSnake moves downside");
                }
                movePlayer1(); // ausführen "movePlayer"-Methode
            }
            pbCanvas.Invalidate(); // aktualisiert den "pictureBox" ("pbCanvas")
                                   // und aktualisiert die "graphics" darauf
        }

        // gleicher Vorgang wie updateScreenSPMP()-Methode
        // anstatt "Arrow keys" "WASD keys"
        // und nur für Singleplayermodus
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
                    Console.WriteLine("Game started");
                }
                else if (currentKeyPressedMainGamePage == (int)Keys.Escape)
                {
                    tabController.SelectedTab = PlayerChoicePage;
                    startGame();
                    Console.WriteLine("Game started");
                }
            }
            else if (currentKeyPressedMainGamePage != -1)
            {
                if (currentKeyPressedMainGamePage == (int)Keys.D)
                {
                    Settings.directionBlueSnake = Directions.Right;
                    Console.WriteLine("BlueSnake moves to the right");
                }
                else if (currentKeyPressedMainGamePage == (int)Keys.A)
                {
                    Settings.directionBlueSnake = Directions.Left;
                    Console.WriteLine("BlueSnake moves to the left");
                }
                else if (currentKeyPressedMainGamePage == (int)Keys.W)
                {
                    Settings.directionBlueSnake = Directions.Up;
                    Console.WriteLine("BlueSnake moves to the upside");
                }
                else if (currentKeyPressedMainGamePage == (int)Keys.S)
                {
                    Settings.directionBlueSnake = Directions.Down;
                    Console.WriteLine("BlueSnake moves to the downside");
                }
                movePlayer2();
            }
            pbCanvas.Invalidate();
        }

        // die Methode dient daszu die keys freizugeben
        private void tabController_KeyDown(object sender, KeyEventArgs e)
        {
            // wenn Singleplayermodus dann werden die "Arrow keys" für den einen Spieler aktiviert
            // ansonsten werden die Keys deaktiviert
            if (startedSP)
            {
                updateScreenSPMP(sender, e);
                currentKeyPressedMainGamePage = e.KeyValue;
            }
            // wenn Multiplayermodus dann werden die "Arrow keys" und "WASD keys" für den zwei Spieler aktiviert
            // ansonsten werden die Keys deaktiviert
            else if (startedMP)
            {
                updateScreenSPMP(sender, e);
                updateScreenSP(sender, e);
                currentKeyPressedMainGamePage = e.KeyValue;

            }
            e.Handled = true;
        }
    }
}
