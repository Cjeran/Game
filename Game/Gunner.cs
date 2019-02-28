﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    class Gunner
    {
        int x, y, size, speed;
        Color colour;

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
            else if (direction == "down"){y += speed;}
            else if (direction == "left"){x -= speed;}
            else if (direction == "right"){x += speed;}
        }
    }
}