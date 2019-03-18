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
    public partial class GameScreen : UserControl
    {
        
        new Random randGen = new Random();
        int shots, score, timer, difficulty, kills;
        Gunner g;
        Boolean leftKeyDown, rightKeyDown, upKeyDown, downKeyDown, spaceKeyDown, bKeyDown, nKeyDown, mKeyDown, gameOver;
        Boolean loaded = true;
        Font labelFont = new Font("Mongolian Baiti", 16);
        List<Projectile> bullets = new List<Projectile>();
        List<Projectile> bolts = new List<Projectile>();
        List<Gunner> enemies = new List<Gunner>();

        public GameScreen()
        {
            InitializeComponent();
            DoubleBuffered = true;
            gameOver = false;
            OnStart();
        }

        private void GameScreen_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftKeyDown = true;
                    break;
                case Keys.Right:
                    rightKeyDown = true;
                    break;
                case Keys.Up:
                    upKeyDown = true;
                    break;
                case Keys.Down:
                    downKeyDown = true;
                    break;
                case Keys.Space:
                    spaceKeyDown = true;
                    break;
                case Keys.B:
                    bKeyDown = true;
                    break;
                case Keys.N:
                    nKeyDown = true;
                    break;
                case Keys.M:
                    mKeyDown = true;
                    break;
            }
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftKeyDown = true;
                    break;
                case Keys.Right:
                    rightKeyDown = true;
                    break;
                case Keys.Up:
                    upKeyDown = true;
                    break;
                case Keys.Down:
                    downKeyDown = true;
                    break;
                case Keys.Space:
                    spaceKeyDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftKeyDown = false;
                    break;
                case Keys.Right:
                    rightKeyDown = false;
                    break;
                case Keys.Up:
                    upKeyDown = false;
                    break;
                case Keys.Down:
                    downKeyDown = false;
                    break;
                case Keys.Space:
                    spaceKeyDown = false;
                    break;
                case Keys.B:
                    bKeyDown = false;
                    break;
                case Keys.N:
                    nKeyDown = false;
                    break;
                case Keys.M:
                    mKeyDown = false;
                    break;
            }
        }

        public void OnStart()
        {
            Gunner e = new Gunner(randGen.Next(1, 5));
            enemies.Add(e);
            g = new Gunner(this.Width / 2 - 10, this.Height / 2 - 10, 20, 7, Color.LightCyan);
            Gunner x = new Gunner(0, 0, 0, 0, Color.Red);
            enemies.Add(x);
            timer = 0;
            difficulty = 25;
            gameTime.Start();
        }
       
        private void gameTime_Tick(object sender, EventArgs e)
        {
            //Update Timer
            timer++;

            //Increase Difficulty if its time
            if (timer % 25 == 0 && difficulty > 1)
            {
                difficulty = difficulty - 1;
            }

            //Movement Detection
            if (leftKeyDown == true && g.x > 0){ g.Move("left"); }
            if (rightKeyDown == true && g.x < this.Width - g.size) { g.Move("right"); }
            if (upKeyDown == true && g.y > 0) { g.Move("up"); }
            if (downKeyDown == true && g.y < this.Height - g.size) { g.Move("down"); }

            //Create and move projectiles with directional input, as well as remove drop off bullets
            if (spaceKeyDown == true && loaded == true)
            {
                Projectile p = new Projectile(g.x + g.size / 2 - 2, g.y, 4, 10, 20, Color.Silver, "down");
                bullets.Add(p);
                loaded = false;
                shots++;
            }
            else if (bKeyDown == true && loaded == true)
            {
                Projectile p = new Projectile(g.x + 10, g.y + g.size / 2 - 2, 10, 4, 20, Color.Silver, "left");
                bullets.Add(p);
                loaded = false;
                shots++;
            }
            else if (nKeyDown == true && loaded == true)
            {
                Projectile p = new Projectile(g.x + g.size / 2 - 2, g.y + 10, 4, 10, 20, Color.Silver, "up");
                bullets.Add(p);
                loaded = false;
                shots++;
            }
            else if (mKeyDown == true && loaded == true)
            {
                Projectile p = new Projectile(g.x, g.y + g.size / 2 - 2, 10, 4, 20, Color.Silver, "right");
                bullets.Add(p);
                loaded = false;
                shots++;
            }

            for (int i = 0; i < bullets.Count; i++)
            {
                bullets[i].Move();
                if (bullets[i].y < bullets[i].initialY - 100 
                    || bullets[i].y > bullets[i].initialY + 100 
                    || bullets[i].x > bullets[i].initialX + 100 
                    || bullets[i].x < bullets[i].initialX - 100)
                {
                    bullets.Remove(bullets[i]);
                }
            }

            //Move enemies
            foreach (Gunner x in enemies) { x.Track(g); }

            //Add enemies
            if (timer % difficulty == 0)
            {
                Gunner x = new Gunner(randGen.Next(1, 5));
                enemies.Add(x);
            }

            //Remove Shot Enemies
            Collision();

            //Game Over if hero collides with enemies
            for (int x = 0; x < enemies.Count; x++)
            {
                if (g.Death(enemies[x]))
                {
                    gameOver = true;
                    break;
                }
            }

            //If gameOver is true, go to end screen.
            if (gameOver)
            {
                Form1.finalKills = kills;
                Form1.finalScore = kills * 75 + score * 5;
                Form1.finalTime = score;

                Form f = this.FindForm();
                f.Controls.Remove(this);

                EndScreen es = new EndScreen();
                f.Controls.Add(es);

                this.Dispose();
            }

            //Add 5 to score every tick for surviving
            score++;

            //Makes it so you cannot hold the firing buttons down
            if (spaceKeyDown == false && bKeyDown == false && nKeyDown == false && mKeyDown == false){loaded = true;}
           
            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //create total score
            int totalScore = kills * 75 + score * 5;
            foreach (Projectile p in bullets) { e.Graphics.FillRectangle(new SolidBrush(p.colour), p.x, p.y, p.width, p.height); }
            foreach (Gunner x in enemies) { e.Graphics.FillEllipse(new SolidBrush(x.colour), x.x, x.y, x.size, x.size); }
            e.Graphics.FillRectangle(new SolidBrush(g.colour), g.x, g.y, g.size, g.size);
            e.Graphics.DrawString("Shots: " + shots, labelFont, new SolidBrush(Color.Black), this.Width - 100, 0);
            e.Graphics.DrawString("Score: " + totalScore, labelFont, new SolidBrush(Color.Black), this.Width - 100, 17);
        }


        public void Collision()
        {
            for (int p = 0; p < bullets.Count; p++)
            {
                for (int x = 0; x < enemies.Count; x++)
                {
                    if (enemies[x].Shot(bullets[p]))
                    {
                        bullets.Remove(bullets[p]);
                        enemies.Remove(enemies[x]);
                        kills += 1;
                        break;
                    }
                }
            }
        }
    }
}
