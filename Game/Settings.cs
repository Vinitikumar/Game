using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    // dies ist ein Enum-Klasse namens "Directions"
    // wir verwenden "enum", weil es einfacher ist, die Richtungen zu klassifizieren
    // für das Spiel
    public enum Directions
    {
        Left,
        Right,
        Up,
        Down
    };
    class Settings
    {
        // Klassen werden gesetzt
        public static int Width { get; set; } 
        public static int Height { get; set; }
        public static int Speed { get; set; } 
        public static int Player1Score { get; set; }
        public static int Player2Score { get; set; }
        public static int Points { get; set; } 
        public static bool GameOver { get; set; }
        public static Directions directionGreenSnake { get; set; }
        public static Directions directionBlueSnake { get; set; }

        // das ist die Default-"Settingsfunction"
        public Settings()
        {
            Width = 16; 
            Height = 16; 
            Speed = 10;
            Player1Score = 00;
            Player2Score = 00;
            Points = 100; 
            GameOver = false;
            directionGreenSnake = Directions.Down;
            directionBlueSnake = Directions.Down;
        }
    }
}