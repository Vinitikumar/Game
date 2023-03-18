using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // die Hashtable-Klasse befindet sich in der "Collections"
using System.Windows.Forms;

namespace Game
{
    class Input
    {
        private static Hashtable keyTable = new Hashtable();
        // Erstellung einer neue Instanz der Hashtable-Klasse
        // diese Klasse wird verwendet, um die darin eingefügten "Keys" zu optimieren
        public static bool keyPress(Keys key)
        {
            // diese Funktion gibt einen Schlüssel zurück zur Klasse
            if (keyTable[key] == null)
            {
                return false; // wenn die Hashtabelle leer ist, wird "false" zurückgegeben
            }
            return (bool)keyTable[key];
        }

        public static void changeState(Keys key, bool state)
        {
            // diese Funktion ändert den Zustand der "Keys" und der Spieler1/ Spieler2 damit 
            // diese Funktion hat zwei Argumente "Key" und "state"
            keyTable[key] = state;
        }

    }
}