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
    public partial class StartPages : Form
    {
        public StartPages()
        {
            InitializeComponent();
        }

        private void singlePlayer_Click(object sender, EventArgs e)
        {
            GameScreenForSingle singlePlayerPage = new GameScreenForSingle();
            singlePlayerPage.Show();
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            tabController.SelectedTab = PlayerChoicesPage;
        }
    }
}
