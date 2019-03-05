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
        public int x, y, size, speed;
        public Color colour;

        public Gunner(int _x, int _y, int _size, int _speed, Color _colour)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            colour = _colour;
        }

        public void Move(string direction)
        {
            //Depending on input, moves gunner in given direction
            if (direction == "up"){y -= speed;} 
            if (direction == "down"){y += speed;}
            if (direction == "left"){x -= speed;}
            if (direction == "right"){x += speed;}
        }
    }
}
