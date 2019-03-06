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
        int shots, score;
        Gunner g;
        Boolean leftKeyDown, rightKeyDown, upKeyDown, downKeyDown, spaceKeyDown, bKeyDown, nKeyDown, mKeyDown;
        Boolean loaded = true;
        Font labelFont = new Font("Mongolian Baiti", 24);
        List<Projectile> bullets = new List<Projectile>();

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
            DoubleBuffered = true;
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
            g = new Gunner(this.Width / 2 - 10, this.Height / 2 - 10, 20, 7, Color.LightCyan);
            gameTime.Start();
        }
       
        private void gameTime_Tick(object sender, EventArgs e)
        {
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

            //Makes it so you cannot hold the firing buttons down
            if (spaceKeyDown == false && bKeyDown == false && nKeyDown == false && mKeyDown == false){loaded = true;}
           
            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Projectile p in bullets) { e.Graphics.FillRectangle(new SolidBrush(p.colour), p.x, p.y, p.width, p.height); }
            e.Graphics.FillRectangle(new SolidBrush(g.colour), g.x, g.y, g.size, g.size);
            e.Graphics.DrawString(shots + "", labelFont, new SolidBrush(Color.Black), this.Width - 100, 0);
            e.Graphics.DrawString(score + "", labelFont, new SolidBrush(Color.Black), this.Width - 100, 25);
        }
    }
}
