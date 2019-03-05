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
        int debug = 0;
        Gunner g;
        Boolean leftKeyDown, rightKeyDown, upKeyDown, downKeyDown, spaceKeyDown;
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
            }
        }

        public void OnStart()
        {
            g = new Gunner(this.Width / 2 - 10, this.Height - 100, 20, 7, Color.LightCyan);
            gameTime.Start();
        }
       
        private void gameTime_Tick(object sender, EventArgs e)
        {
            //Movement Detection
            if (leftKeyDown == true && g.x > 0){ g.Move("left"); }
            if (rightKeyDown == true && g.x < this.Width - g.size) { g.Move("right"); }
            if (upKeyDown == true && g.y > 0) { g.Move("up"); }
            if (downKeyDown == true && g.y < this.Height - g.size) { g.Move("down"); }

            //Create and move projectiles, as well as remove drop off bullets
            if (spaceKeyDown == true)
            {
                Projectile p = new Projectile(g.x + g.size / 2, g.y + 10, 3, 10, -20, Color.Silver);
                bullets.Add(p);
            }
            for (int i = 0; i < bullets.Count; i++)
            {
                bullets[i].Move();
                if (bullets[i].y < bullets[i].initial - this.Height / 3)
                {
                    bullets.Remove(bullets[i]);
                }
            }
           
            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(g.colour), g.x, g.y, g.size, g.size);
            foreach (Projectile p in bullets) { e.Graphics.FillRectangle(new SolidBrush(p.colour), p.x, p.y, p.width, p.height); }
        }
    }
}
