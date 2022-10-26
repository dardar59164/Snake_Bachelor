using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Bachelor.Game
{
    public class Snake : Board
    {
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'z';
        char direction = 'u';
        List<Position> snakeParts;
        public int y { get; set; }
        public int x { get; set; }

        public Snake()
        {
            x = Width/2;
            y = Height/2;
            snakeParts = new List<Position>();
            snakeParts.Add(new Position(x, y));
        }

        public override void Draw()
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

        public void Move()
        {
            Direction();
            if (direction == 'u')
            {
                if (y - 1 > 0) y--;
            }
            if (direction == 'd')
            {
                if (y + 1 < Height ) y++;
            }
            if (direction == 'r')
            {
                if (x + 1 < Width) x++;
            }
            if (direction == 'l')
            {
                if (x - 1 > 0) x--;
            }
            snakeParts.Add(new Position(x, y));
            snakeParts.RemoveAt(0);
            Thread.Sleep(100);
        }

        public void Grow(Food food,Position foodPosition)
        {
            Position snakeHead = snakeParts[snakeParts.Count - 1]; //Snake Head Position
            if (snakeHead.x == foodPosition.x && snakeHead.y == foodPosition.y)
            {
                snakeParts.Add(new Position(x, y));
                food.newFoodLocation();
            }
        }
    }
}
