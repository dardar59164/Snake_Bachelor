using Snake_Bachelor.Game;

namespace Snake_Bachelor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            Board gameboard = new Board();

            while (!end)
            {
                gameboard.drawBoard();
                Console.Read();
            }
        }
    }
}