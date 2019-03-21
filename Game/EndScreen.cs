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
            if (Form1.finalScore > Form1.highScore)
            {
                Form1.highScore = Form1.finalScore;
                highscoreLabel.Text = "New Highscore!";
            }
            else
            {
                highscoreLabel.Text = "" + Form1.highScore;
            }
        }

        private void gameOverLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "StartScreen");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "GameScreen");
        }
    }
}
