using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter.Combat
{
    static public class MyMath
    {
        static public int Clamp(int i, int floor, int ceiling)
        {
            if (i < floor) i = floor;
            if (i > ceiling) i = ceiling;
            return i;
        }
    }
}
