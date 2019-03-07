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
        }
    }
}
