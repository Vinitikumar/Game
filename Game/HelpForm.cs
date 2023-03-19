using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            helpInfo();
        }
        private void helpInfo()
        {
            //Infotext wie dieser Spiel gespielt wird
            string helpInfoText = "You have two buttons:\r\n\r\nSingleplayer Button\r\n-> only one Player\r\n-> Player 1 (GreenSnake) can play with the arrow keys\r\n\r\nMultiplayer Button\r\n-> two Players \r\n-> Player 1 (BlueSnake) can play with the WASD keys\r\n-> Player 2 (GreenSnake) can play with the arrow keys\r\n\r\n! If you are in the game page,\nuse the enter key to start the game\nand with the esc key you can go back to the player choices page\r\n";
            InfoText.Text = helpInfoText;
            InfoText.Visible = true;
        }
    }
}
