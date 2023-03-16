using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Game
{
    class Circle
    {
        public int X { get; set; } // dies ist eine public int-Klasse namens x
        public int Y { get; set; } // dies ist eine public int-Klasse namens y

        public Circle()
        {
            // diese Funktion setzt x und y auf 0 zurück
            X = 0;
            Y = 0;
        }
    }
}

