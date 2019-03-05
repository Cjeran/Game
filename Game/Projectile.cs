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
        public int x, y, width, height, speed, initial;
        public Color colour;

        public Projectile(int _x, int _y, int _width, int _height, int _speed, Color _colour)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            speed = _speed;
            colour = _colour;
            initial = _y;
        }

        public void Move()
        {
            y += speed;
        }
    }
}
