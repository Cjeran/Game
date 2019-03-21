using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    class Projectile
    {
        public Random randGen = new Random();
        public int x, y, width, height, speed, initialY, initialX;
        public string direction;
        public Color colour;
        public Rectangle r;

        public Projectile(int _x, int _y, int _width, int _height, int _speed, Color _colour, string _direction)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            speed = _speed;
            colour = _colour;
            initialY = _y;
            initialX = _x;
            direction = _direction;
            r = new Rectangle(x, y, width, height);
        }

        public Projectile(int initial, Gunner g)
        {
            if (initial == 1)
            {
                x = g.x + g.size / 2;
                y = -20;
                initialX = x;
                initialY = y;
                width = 5;
                height = 20;
                speed = 20;
                colour = Color.Maroon;
                direction = "down";
            }
            else if (initial == 2)
            {
                x = g.x + g.size / 2 ;
                y = 500;
                initialX = x;
                initialY = y;
                width = 5;
                height = 20;
                speed = 20;
                colour = Color.Maroon;
                direction = "up";
            }
            else if (initial == 3)
            {
                x = 800;
                y = g.y + g.size / 2;
                initialX = x;
                initialY = y;
                width = 20;
                height = 5;
                speed = 20;
                colour = Color.Maroon;
                direction = "left";
            }
            else if (initial == 4)
            {
                x = -20;
                y = g.y + g.size / 2;
                initialX = x;
                initialY = y;
                width = 20;
                height = 5;
                speed = 20;
                colour = Color.Maroon;
                direction = "right";
            }
        }

        public void Move()
        {
            if (direction == "up")
            {
                y -= speed;
            }
            else if (direction == "down")
            {
                y += speed;
            }
            else if (direction == "left")
            {
                x -= speed;
            }
            else if (direction == "right")
            {
                x += speed;
            }

            r = new Rectangle(x, y, width, height);
        }
    }
}
