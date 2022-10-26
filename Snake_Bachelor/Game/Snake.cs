using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Bachelor.Game
{
    public class Snake
    {
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();

        public int y { get; set; }
        public int x { get; set; }

        public Snake()
        {
            x = 30;
            y = 15;
        }

        public void drawSnake()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("O");
        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                char key = keyInfo.KeyChar;
            }
        }
    }
}
