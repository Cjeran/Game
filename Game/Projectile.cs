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

        public Projectile(int initial)
        {
            if (initial == 1)
            {
                x = randGen.Next(1, 797);
               // y = 
            }
            else if (initial == 2)
            {

            }
            else if (initial == 3)
            {

            }
            else if (initial == 4)
            {

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
