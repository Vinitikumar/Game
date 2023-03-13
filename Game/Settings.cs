using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public enum Directions
    {
        Left,
        Right,
        Up,
        Down
    };
    class Settings
    {
        public static int Width { get; set; } 
        public static int Height { get; set; }
        public static int Speed { get; set; } 
        public static int Player1Score { get; set; }
        public static int Player2Score { get; set; }
        public static int Points { get; set; } 
        public static bool GameOver { get; set; } 
        public static Directions direction { get; set; }
        public static Directions direction2 { get; set; }

        public Settings()
        {
            Width = 16; 
            Height = 16; 
            Speed = 10;
            Player1Score = 00;
            Player2Score = 00;
            Points = 100; 
            GameOver = false; 
            direction = Directions.Down;
            direction2 = Directions.Down;
        }
    }
}