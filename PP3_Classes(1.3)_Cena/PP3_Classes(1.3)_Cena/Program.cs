using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PP3_Classes_1._3__Cena;

namespace _2Y_OOP_2324_ADeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _1GameMechanics Game = new _1GameMechanics();
            int FinalScore = 0;
            bool Replay = true;
            string ReplayChoice = "";
            
            while(Replay)
            {
                FinalScore = Game.Introduction();
                Console.WriteLine("In the end, you got " + FinalScore + " over 21");
                Console.WriteLine("Would you like to play again? Type the first letter of your choice" +
                    " to choose. (Y)es or (N)o");
                ReplayChoice = Console.ReadLine().ToUpper();

                if(ReplayChoice == "Y")
                {
                    Replay = true;
                }
                else if(ReplayChoice == "N")
                {
                    Replay = false;
                }
                Console.Clear();
            }
            Console.WriteLine("Thank you for playing!");
            Console.ReadKey();
            
        }
    }
}