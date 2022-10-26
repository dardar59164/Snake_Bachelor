using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Bachelor.Game
{
    public class Food : Board
    {
        public Position foodPos = new Position(0,0);
        Random rand = new Random();
        public Food()
        {
            foodPos.x = rand.Next(1,Width);
            foodPos.y = rand.Next(1,Height);
        }

        public override void Draw() //Override Board.Draw() pour afficher la nourriture
        {
            Console.SetCursorPosition(foodPos.x, foodPos.y);
            Console.Write('*');
        }

        public Position locateFood() //Renvoie la position de la nourriture
        {
            return foodPos;
        }

        public void newFoodLocation() //Réattribue des coordonnées random au food consommé
        {
            foodPos.x = rand.Next(1, Width);
            foodPos.y = rand.Next(1, Height);
        }
    }
}