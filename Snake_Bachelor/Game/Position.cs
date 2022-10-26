using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Bachelor.Game
{
    public class Position
    {
        public int x { get; set; }
        public int y { get; set; }
        public Position(int x, int y) //Tout est dans le nom :)
        {
            this.x = x;
            this.y = y;
        }
    }
}
