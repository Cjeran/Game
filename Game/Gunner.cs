using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    class Gunner
    {
        public Random randGen = new Random();
        public int x, y, size, speed;
        public Color colour;
        public Rectangle r;

        public Gunner(int _x, int _y, int _size, int _speed, Color _colour)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            colour = _colour;
            r = new Rectangle(x, y, size, size);
        }

        public Gunner(int initial)
        {
            if (initial == 1)
            {
                x = randGen.Next(1, 751);
                y = -50;
                size = 50;
                speed = 10;
                colour = Color.Red;
            }
            else if (initial == 2)
            {
                x = 800;
                y = randGen.Next(1, 451);
                size = 50;
                speed = 10;
                colour = Color.Red;
            }
            else if (initial == 3)
            {
                x = randGen.Next(1, 751);
                y = 500;
                size = 50;
                speed = 10;
                colour = Color.Red;
            }
            else if (initial == 4)
            {
                x = -50;
                y = randGen.Next(1, 451);
                size = 50;
                speed = 10;
                colour = Color.Red;
            }
        }

        public void Move(string direction)
        {
            //Depending on input, moves gunner in given direction
            if (direction == "up"){y -= speed;} 
            if (direction == "down"){y += speed;}
            if (direction == "left"){x -= speed;}
            if (direction == "right"){x += speed;}
        }

        public void Track(Gunner g)
        {
            if (g.x > x) { x += speed; }
            if (g.x < x) { x -= speed; }
            if (g.y > y) { y += speed; }
            if (g.y < y) { y -= speed; }
        }

        public Boolean Shot(Projectile p)
        {
            Rectangle projectileRect = new Rectangle(p.x, p.y, p.width, p.height);
            Rectangle enemyRect = new Rectangle(x, y, size, size);

            return enemyRect.IntersectsWith(projectileRect);
        }
    }
}
