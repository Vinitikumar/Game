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
        // wir erstellen eine neue Instanz der Hastable-Klasse
        // diese Klasse wird verwendet, um die darin eingefügten Tasten zu optimieren
        public static bool KeyPress(Keys key)
        {
            // diese Funktion gibt einen Schlüssel zurück zur Klasse
            if (keyTable[key] == null)
            {
                return false; // wenn die Hashtabelle leer ist, geben wir "false" zurück
            }
            return (bool)keyTable[key];
        }

        public static void changeState(Keys key, bool state)
        {
            // diese Funktion ändert den Zusatnd der Tasten und das Players damit 
            // diese Funktion hat zwei Argumente "Key" und "state"
            keyTable[key] = state;
        }

    }
}