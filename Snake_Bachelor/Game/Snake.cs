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
        char key = 'z';
        char direction = 'u';
        List<Position> snakeParts;
        public int y { get; set; }
        public int x { get; set; }

        public Snake()
        {
            x = 30;
            y = 15;
            snakeParts = new List<Position>();
            snakeParts.Add(new Position(x, y));
        }

        public void drawSnake()
        {
            foreach(Position pos in snakeParts)
            {
                Console.SetCursorPosition(pos.x, pos.y);
                Console.Write("O");
            }
        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }

        private void Direction()
        {
            switch (key)
            {
                case 'z':
                    if (direction != 'd')
                    {
                        direction = 'u'; //'u' = "up"
                    }
                    break;
                case 'q':
                    if (direction != 'r')
                    {
                        direction = 'l'; //'l' = "left"
                    }
                    break;
                case 's':
                    if (direction != 'u')
                    {
                        direction = 'd'; //'d' = "down"
                    }
                    break;
                case 'd':
                    if (direction != 'l')
                    {
                        direction = 'r'; //'r' = "right"
                    }
                    break;
                default:
                    break;
            }
        }

        public void move()
        {
            Direction();
            if (direction == 'u')
            {
                y--;
            }
            if (direction == 'd')
            {
                y++;
            }
            if (direction == 'r')
            {
                x++;
            }
            if (direction == 'l')
            {
                x--;
            }
            snakeParts.Add(new Position(x, y));
            snakeParts.RemoveAt(0);
            Thread.Sleep(100);
        }
    }
}
