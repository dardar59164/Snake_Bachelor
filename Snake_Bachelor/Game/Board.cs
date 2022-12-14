using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Bachelor.Game
{
    public class Board
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Board()
        {
            Console.CursorVisible = false;
            //↓↓ Ajuste la taille de la console ↓↓
            Width = 60;
            Height = 30;
        }

        public virtual void Draw() //Crée les murs de la map
        {
            Console.Clear();
            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("#");
            }
            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, Height);
                Console.Write("#");
            }
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("#");
            }
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(Width, i);
                Console.Write("#");
            }
        }
    }
}
