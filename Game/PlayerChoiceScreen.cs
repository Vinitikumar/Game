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
    public partial class PlayerChoiceScreen : Form
    {
        public PlayerChoiceScreen()
        {
            InitializeComponent();
        }

        private void singlePlayer_Click(object sender, EventArgs e)
        {
            GameScreenForSingle gameWindow = new GameScreenForSingle();

            gameWindow.Show();
        }

        private void multiPlayer_Click(object sender, EventArgs e)
        {

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpScreen gameWindow = new HelpScreen();

            gameWindow.Show();
        }
    }
}
