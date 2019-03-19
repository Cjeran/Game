using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class EndScreen : UserControl
    {
        public EndScreen()
        {
            InitializeComponent();

            killLabel.Text = "" + Form1.finalKills;
            scoreLabel.Text = "" + Form1.finalScore;
            timeLabel.Text = "" + Form1.finalTime;
        }

        private void gameOverLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
