using Snake_Bachelor.Game;

namespace Snake_Bachelor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            Board gameboard = new Board();
            Snake snake = new Snake();
            Food food = new Food();

            while (!end)
            {
                gameboard.Draw();
                snake.Input();
                food.Draw();
                snake.Draw();
                snake.Move();
                snake.Grow(food,food.locateFood());
            }
        }
    }
}