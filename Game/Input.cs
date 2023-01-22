using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections; 
using System.Windows.Forms;

namespace Game
{
    class Input
    {
        private static Hashtable keyTable = new Hashtable();


        public static bool KeyPress(Keys key)
        {


            if (keyTable[key] == null)
            {
                return false;
            }
            return (bool)keyTable[key];
        }

        public static void changeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }

    }
}